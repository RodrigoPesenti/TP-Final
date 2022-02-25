using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using TP_Final.API;
using TP_Final.DAL;
using TP_Final.DAL.EntityFramework;
using TP_Final.Domain;
using TP_Final.Excepciones;
using TP_Final.IO;

namespace TP_Final
{
    public class Fachada
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<LibroDTO> ObtenerLibrosDisponibles()
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new AccountManagerDbContext()))
            {
                List<LibroDTO> listaLibrosDTO = new List<LibroDTO>();
                IEnumerable<Libro> listaLibros = bUoW.LibroRepository.GetAll().ToList();


                foreach (var libro in listaLibros)
                {
                    List<EjemplarDTO> listaEjemplaresDTO = new List<EjemplarDTO>();
                    foreach (var ejemplar in libro.Ejemplares)
                    {
                        EjemplarDTO ejemplarDTO = new EjemplarDTO
                        {
                            ID = ejemplar.ID,
                            ISBN = ejemplar.Libro.ISBN,
                            Disponible = ejemplar.disponible()
                        };
                        listaEjemplaresDTO.Add(ejemplarDTO);
                    }

                    LibroDTO libroDTO = new LibroDTO
                    {
                        Titulo = libro.Titulo,
                        Autor = libro.Autor,
                        ISBN = libro.ISBN,
                        CantEjem = libro.EjemplaresDisponibles().Count,
                        Ejemplares = listaEjemplaresDTO
                    };
                    listaLibrosDTO.Add(libroDTO);
                }
                bUoW.Complete();

                log.Info("Se obtuvo una lista de DTOs de los libros disponibles");
                return listaLibrosDTO;
            }
        }

        public List<PrestamoDTO> ObtenerPrestamosNoDevueltos()
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new AccountManagerDbContext()))
            {
                IEnumerable<Prestamo> listaPrestamos = bUoW.PrestamoRepository.GetAll().ToList();

                List<PrestamoDTO> listaPrestamosDTO = new List<PrestamoDTO>();
                foreach (var prestamo in listaPrestamos)
                {
                    if (!prestamo.devuelto())
                    {
                        PrestamoDTO prestamoDTO = new PrestamoDTO
                        {
                            ID = prestamo.ID,
                            IDEjemplar = prestamo.Ejemplar.ID,
                            Libro = prestamo.Ejemplar.Libro.Titulo,
                            Usuario = prestamo.Usuario.Nombre,
                            FechaPrestamo = prestamo.FechaPrestamo,
                            FechaDevolucion = prestamo.FechaDevolucion
                        };
                        listaPrestamosDTO.Add(prestamoDTO);
                    }
                }

                log.Info("Se obtuvo una lista de DTOs de los prestamos no devueltos");
                return listaPrestamosDTO;
            }
        }

        public LibroDTO ObtenerLibro(Int64 pLibroISBN)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new AccountManagerDbContext()))
            {
                Libro libro = bUoW.LibroRepository.GetPorISBN(pLibroISBN);
                LibroDTO libroDTO = new LibroDTO();
                List<EjemplarDTO> listaEjemplaresDTO = new List<EjemplarDTO>();
                foreach (var ejemplar in libro.Ejemplares)
                {
                    EjemplarDTO ejemplarDTO = new EjemplarDTO
                    {
                        ID = ejemplar.ID,
                        ISBN = ejemplar.Libro.ISBN,
                        Disponible = ejemplar.disponible()
                    };
                    listaEjemplaresDTO.Add(ejemplarDTO);
                }
                libroDTO.Titulo = libro.Titulo;
                libroDTO.Autor = libro.Autor;
                libroDTO.ISBN = libro.ISBN;
                libroDTO.CantEjem = libro.EjemplaresDisponibles().Count;
                libroDTO.Ejemplares = listaEjemplaresDTO;

                log.Info("Se obtuvo un DTO del libro de ID: " + libro.ID);
                return libroDTO;

            }
        }

        public List<UsuarioDTO> ObtenerUsuarios()
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new AccountManagerDbContext()))
            {
                IEnumerable<Usuario> listaUsuario = bUoW.UsuarioRepository.GetAll();
                List<UsuarioDTO> listaUsuariosDTO = new List<UsuarioDTO>();
                foreach (var usuario in listaUsuario)
                {
                    UsuarioDTO usuarioDTO = new UsuarioDTO
                    {
                        Nombre = usuario.Nombre,
                        Puntos = usuario.Puntos,
                        Mail = usuario.Mail,
                        TipoUsuario = usuario.Tipo
                    };
                    listaUsuariosDTO.Add(usuarioDTO);
                }

                log.Info("Se obtuvo una lista de DTOs de los usuarios");
                return listaUsuariosDTO;
            }
        }

        public bool ComprobarLoginUsuario(string pNombreUsuario, string pContraseña)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new AccountManagerDbContext()))
            {
                Usuario usuario = bUoW.UsuarioRepository.GetPorUsuario(pNombreUsuario);

                if (usuario != null)
                {
                    byte[] data = System.Text.Encoding.ASCII.GetBytes(pContraseña);
                    data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                    String contraseñaEncriptada = System.Text.Encoding.ASCII.GetString(data);

                    if (usuario.Contraseña == contraseñaEncriptada)
                    {
                        return true;
                    }
                    else
                    {
                        throw new ContraseñaIncorrectaException("La contraseña ingresada es incorrecta");
                    }
                }
                else
                {
                    throw new NullReferenceException("El usuario ingresado no existe");
                }
            }
        }

        public bool ComprobarAdministradorUsuario(string pNombreUsuario)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new AccountManagerDbContext()))
            {
                Usuario usuario = bUoW.UsuarioRepository.GetPorUsuario(pNombreUsuario);

                if (usuario != null)
                {
                    if (usuario.Tipo == TipoUsuario.Administrador)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
        }

        public void AltaUsuario(string pNombre, string pContraseña, string pMail, TipoUsuario pTipo, TipoNotificacion pTipoNotificacion)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new AccountManagerDbContext()))
            {
                //Encriptamos la contraseña
                byte[] data = System.Text.Encoding.ASCII.GetBytes(pContraseña);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                String contraseñaEncriptada = System.Text.Encoding.ASCII.GetString(data);

                Usuario usuario = new Usuario
                {
                    Puntos = 0,
                    Nombre = pNombre,
                    Contraseña = contraseñaEncriptada,
                    Tipo = pTipo,
                    Mail = pMail,
                    TipoNotificacion = pTipoNotificacion
                };
                bUoW.UsuarioRepository.Add(usuario);
                bUoW.Complete();
                log.Info("Se creo un usuario");
            }
        }
        //Poner nombre representativo a IApi
        public List<LibroDTO> BuscarLibroEnAPI(string pTituloLibro)
        {
            IApiConsultasBiblioteca apiConsultas = new OpenLibrary();
            log.Info("Se consulto la API");
            return apiConsultas.Consultar(pTituloLibro);
        }

        public void AltaLibro(LibroDTO pLibroDTO)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new AccountManagerDbContext()))
            {
                Libro libroCargar = new Libro
                {
                    ISBN = pLibroDTO.ISBN,
                    Titulo = pLibroDTO.Titulo,
                    Autor = pLibroDTO.Autor
                };

                bUoW.LibroRepository.Add(libroCargar);
                bUoW.Complete();
                log.Info("Se dio de alta un libro");
            }
        }

        public void AltaEjemplar(Int64 pLibroISBN, int pCantAgregar)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new AccountManagerDbContext()))
            {
                Libro libro = bUoW.LibroRepository.GetPorISBN(pLibroISBN);
                for (int i = 1; i <= pCantAgregar; i++)
                {
                    Ejemplar ejem = new Ejemplar { };
                    ejem.Libro = libro;
                    bUoW.EjemplarRepository.Add(ejem);
                    libro.Ejemplares.Add(ejem);
                }
                log.Info("Se dieron de alta " + pCantAgregar + " ejemplares");
                bUoW.Complete();
            }
        }

        public void ActualizarLibro(Int64 pISBN, LibroDTO pDTO)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new AccountManagerDbContext()))
            {
                Libro libro = bUoW.LibroRepository.Get(pISBN);
                libro.Titulo = pDTO.Titulo;
                libro.Autor = pDTO.Autor;
                log.Info("Se actualizo un libro");
                bUoW.Complete();
            }
        }

        public void NuevoPrestamo(string pUsuarioNombre, Int64 pEjemplarID)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new AccountManagerDbContext()))
            {
                Usuario usuario = bUoW.UsuarioRepository.GetPorUsuario(pUsuarioNombre);
                Ejemplar ejemplar = bUoW.EjemplarRepository.Get(pEjemplarID);
                if (ejemplar.disponible())
                {
                    Prestamo prestamo = new Prestamo
                    {
                        FechaPrestamo = DateTime.Now,
                        FechaDevolucion = DateTime.Now.AddDays(5),
                    };
                    prestamo.Ejemplar = ejemplar;
                    prestamo.Usuario = usuario;
                    ejemplar.Prestamos.Add(prestamo);
                    usuario.Prestamos.Add(prestamo);

                    bUoW.PrestamoRepository.Add(prestamo);
                    log.Info("Se registro un prestamo del libro " + ejemplar.Libro.Titulo + " a el usuario " + prestamo.Usuario.Nombre);
                    bUoW.Complete();
                }
                else
                {
                    throw new EjemplarNoDisponibleException("El ejemplar de id " + pEjemplarID + " ya se encuentra prestado");
                }

            }
        }

        public void registrarDevolucion(Int64 pPrestamoID, bool pBuenEstado)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new AccountManagerDbContext()))
            {
                Prestamo prestamo = bUoW.PrestamoRepository.Get(pPrestamoID);
                int diasAtrasados = prestamo.atrasado();

                if (diasAtrasados != 0)
                {
                    prestamo.Usuario.Puntos -= (2 * diasAtrasados);
                    log.Info("Se le restaron " + (2 * diasAtrasados) + "puntos a " + prestamo.Usuario.Nombre);
                }

                if (!pBuenEstado)
                {
                    prestamo.Usuario.Puntos -= 10;
                    log.Info("Se le restaron 10 puntos a " + prestamo.Usuario.Nombre);
                }
                else
                {
                    if (prestamo.atrasado() == 0)
                    {
                        prestamo.Usuario.Puntos += 5;
                        log.Info("Se le sumaron 5 puntos a " + prestamo.Usuario.Nombre);
                    }
                }

                prestamo.registrarDevolucion();
                log.Info("Se registro la devolucion del prestamo de ID: " + prestamo.ID);
                bUoW.Complete();
            }
        }

        public void ExtenderPrestamo(Int64 idPrestamo, int pDias)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new AccountManagerDbContext()))
            {
                Prestamo prestamo = bUoW.PrestamoRepository.Get(idPrestamo);
                Usuario usuario = prestamo.Usuario;
                if (usuario.Puntos >= pDias * 5)
                {
                    if ((prestamo.FechaDevolucion.AddDays(pDias) - prestamo.FechaPrestamo).TotalDays <= 20)
                    {
                        prestamo.extenderPrestamo(pDias);
                        usuario.Puntos -= pDias * 5;
                        log.Info("Se extendio " + pDias + " dias el prestamo de ID: " + prestamo.ID + " al usuario" + usuario.Nombre);
                        bUoW.Complete();
                    }
                    else
                    {
                        log.Info("El usuario " + usuario.Nombre + " intento exceder su limite de extension de prestamos");
                        throw new SuperasteLaExtensionAdmitidaException("Excediste tu limite de extension de prestamo (Un maximo de 15 dias desde la fecha del prestamo)");
                    }
                }
                else
                {
                    log.Info("El usuario " + usuario.Nombre + " no posee puntos para realizar una extension");
                    throw new PuntosInsuficientesException("Posees " + usuario.Puntos + " puntos, pero se requieren " + (pDias * 5) + "puntos, te faltan " + ((pDias * 5) - usuario.Puntos) + "puntos");
                }
            }
        }
    }
}
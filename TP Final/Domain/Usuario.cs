using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.IO.RequestDTO;

namespace TP_Final.Domain
{
    public class Usuario
    {
        public virtual List<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

        public virtual List<Notificacion> Notificaciones { get; set; } = new List<Notificacion>();

        public int Puntos { get; set; }

        public string Nombre { get; set; }

        //Hashear la contraseña (Guardarlo Hasheado)
        public string Contraseña { get; set; }

        public string Mail { get; set; }

        public TipoUsuario Tipo;

        public TipoNotificacion TipoNotificacion { get; set; }

        public Int64 ID { get; set; }


        public void RealizarPrestamo()
        {
            throw new NotImplementedException();
        }

        public void ExtenderPrestamo()
        {
            throw new NotImplementedException();
        }
    }
}

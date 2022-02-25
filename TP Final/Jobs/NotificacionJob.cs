using Quartz;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TP_Final.DAL;
using TP_Final.DAL.EntityFramework;
using TP_Final.Domain;

namespace TP_Final.Jobs
{
    public class NotificacionJob : IJob
    {
        private GestorNotificaciones gestorNotificaciones = new GestorNotificaciones();

        public Task Execute(IJobExecutionContext context)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new AccountManagerDbContext()))
            {
                List<Prestamo> listaPrestamos = bUoW.PrestamoRepository.prestamosADevolverEn(2);
                foreach (var prestamo in listaPrestamos)
                {
                    Usuario usuario = prestamo.Usuario;
                    Notificacion notificacion = new Notificacion
                    {
                        Descripcion = "Notificación de vencimiento de préstamo",
                        Fecha = DateTime.Now.Date,
                        Hora = DateTime.Now.TimeOfDay,
                        Usuario = prestamo.Usuario,
                        Prestamo = prestamo,
                        Tipo = usuario.TipoNotificacion
                    };
                    usuario.Notificaciones.Add(notificacion);
                    gestorNotificaciones.Notificar(notificacion);
                }
                bUoW.Complete();
            }
            return null;
        }
    }
}

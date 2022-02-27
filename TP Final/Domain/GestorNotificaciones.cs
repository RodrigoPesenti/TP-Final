using log4net;
using System.Collections.Generic;

namespace TP_Final.Domain
{
    class GestorNotificaciones
    {
        private Dictionary<TipoNotificacion, INotificador> iNotificadoresPorTipoNotificacion = new Dictionary<TipoNotificacion, INotificador>();

        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GestorNotificaciones()
        {
            NotificadorCompuesto notificadorTipoMail = new NotificadorCompuesto();
            INotificador notificadorMail = new NotificadorMail();

            NotificadorCompuesto notificadorTipoNoRecibir = new NotificadorCompuesto();
            INotificador notificadorNull = new NotificadorNull();

            notificadorTipoMail.agregarNotificador(notificadorMail);

            iNotificadoresPorTipoNotificacion.Add(TipoNotificacion.Mail, notificadorMail);
            iNotificadoresPorTipoNotificacion.Add(TipoNotificacion.NoRecibir, notificadorNull);

        }

        /// <summary>
        /// Devuelve True or False segun la solicitud cumpla los requisitos o no
        /// </summary>
        /// <param name="pSolicitud"></param>
        /// <returns>True or False</returns>
        public void Notificar(Notificacion pNotificacion)
        {
            INotificador notificador = iNotificadoresPorTipoNotificacion[pNotificacion.Tipo];
            notificador.Notificar(pNotificacion);
            log.Info("Se notifico a " + pNotificacion.Prestamo.Usuario.Nombre);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.Domain
{
    public class NotificadorCompuesto : INotificador
    {
        private List<INotificador> INotificadores = new List<INotificador>();

        public NotificadorCompuesto() { }

        public void Notificar(Notificacion pNotificacion)
        {
            foreach (INotificador notificador in INotificadores)
            {
                notificador.Notificar(pNotificacion);
            }
        }

        /// <summary>
        /// Permite agregar un notificador mas para el usuario
        /// </summary>
        /// <param name="pNotificador"></param>
        public void agregarNotificador(INotificador pNotificador)
        {
            INotificadores.Add(pNotificador);
        }
    }
}

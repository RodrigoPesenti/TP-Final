using System;

namespace TP_Final.Domain
{
    public class Notificacion
    {
        public Int64 ID { get; set; }

        public string Descripcion { get; set; }

        public DateTime Fecha { get; set; }

        public TimeSpan Hora { get; set; }

        public TipoNotificacion Tipo { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Prestamo Prestamo { get; set; }
    }


}



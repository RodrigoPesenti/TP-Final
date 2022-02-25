using System;

namespace TP_Final.IO
{
    public class PrestamoDTO
    {
        public Int64 ID { get; set; }

        public Int64 IDEjemplar { get; set; }

        public string Libro { get; set; }

        public string Usuario { get; set; }

        public DateTime FechaPrestamo { get; set; }

        public DateTime FechaDevolucion { get; set; }
    }
}

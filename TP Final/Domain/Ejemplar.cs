using System;
using System.Collections.Generic;
using System.Linq;

namespace TP_Final.Domain
{
    public class Ejemplar
    {
        public Int64 ID { get; set; }

        public virtual Libro Libro { get; set; }

        public virtual List<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

        public bool disponible()
        {
            if (Prestamos.Count != 0)
            {
                Prestamo ultimoPrestamo = Prestamos.Last();
                return ultimoPrestamo.devuelto();
            }
            else
            {
                return true;
            }

        }


    }
}

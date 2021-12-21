using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.Domain
{
    public class Prestamo
    {
        public Int64 ID { get; set; }
        public virtual Ejemplar Ejemplar { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime? FechaDevuelto { get; set; }

        public void registrarDevolucion()
        {
            FechaDevuelto = DateTime.Now;
        }

        /// <summary>
        /// Devuelve la cantidad de dias atrasados de un prestamo
        /// </summary>
        /// <returns>Si esta atrasado devuelve los dias, y si no lo esta devuelve 0</returns>
        public int atrasado()
        {
            if (DateTime.Today > FechaDevolucion)
            {
                return (int)Math.Ceiling((DateTime.Today - FechaDevolucion).TotalDays);
            }
            else
            {
                return 0;
            }
        }

        public void extenderPrestamo(int pDias)
        {
            FechaDevolucion = FechaDevolucion.AddDays(pDias);
        }

        public bool devuelto()
        {
            return FechaDevuelto != null;
        }

    }
}

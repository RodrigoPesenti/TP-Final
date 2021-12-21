using System.Collections.Generic;
using TP_Final.Domain;

namespace TP_Final.DAL
{
    public interface IPrestamoRepository : IRepository<Prestamo>
    {

        public List<Prestamo> prestamosADevolverEn(int pDias);

    }
}

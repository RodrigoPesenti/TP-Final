using EJ_2.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using TP_Final.Domain;

namespace TP_Final.DAL.EntityFramework
{
    public class PrestamoRepository : Repository<Prestamo, AccountManagerDbContext>, IPrestamoRepository
    {
        public PrestamoRepository(AccountManagerDbContext pContext) : base(pContext)
        {

        }

        public List<Prestamo> prestamosADevolverEn(int pDias)
        {
            List<Prestamo> listaDevolver = new List<Prestamo>();
            IEnumerable<Prestamo> listaPrestamos = this.GetAll();  //Obitene la lista de todos los prestamos en la base de datos
            foreach (var prestamo in listaPrestamos)
            {
                double resta = (prestamo.FechaDevolucion - DateTime.Today).TotalDays;
                if ((resta > 0) & (resta <= pDias) & (!prestamo.devuelto()))
                {
                    listaDevolver.Add(prestamo);
                }
            };
            return listaDevolver;
        }
    }
}

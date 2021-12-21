using System;
using TP_Final.Domain;

namespace TP_Final.DAL
{
    public interface ILibroRepository : IRepository<Libro>
    {
        public Libro GetPorISBN(Int64 pLibroISBN);
    }
}

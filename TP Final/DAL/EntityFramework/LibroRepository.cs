using EJ_2.DAL.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TP_Final.Domain;

namespace TP_Final.DAL.EntityFramework
{
    public class LibroRepository : Repository<Libro, AccountManagerDbContext>, ILibroRepository
    {
        private readonly DbContext iDbContext;

        public LibroRepository(AccountManagerDbContext pContext): base(pContext)
        {
            iDbContext = pContext;
        }

        public Libro GetPorISBN(Int64 pLibroISBN)
        {
            return this.iDbContext.Set<Libro>().FirstOrDefault(libro => libro.ISBN == pLibroISBN);
        }
    }
}

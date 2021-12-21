using EJ_2.DAL.EntityFramework;
using TP_Final.Domain;

namespace TP_Final.DAL.EntityFramework
{
    class EjemplarRepository : Repository<Ejemplar, AccountManagerDbContext>, IEjemplarRepository
    {
        public EjemplarRepository(AccountManagerDbContext pContext) : base(pContext)
        {

        }
    }
}


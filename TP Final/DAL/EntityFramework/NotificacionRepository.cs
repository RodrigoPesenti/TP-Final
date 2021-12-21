
using EJ_2.DAL.EntityFramework;
using TP_Final.Domain;

namespace TP_Final.DAL.EntityFramework
{
    public class NotificacionRepository : Repository<Notificacion, AccountManagerDbContext>, INotificacionRepository
    {
        public NotificacionRepository(AccountManagerDbContext pContext) : base(pContext)
        {

        }
    }
}

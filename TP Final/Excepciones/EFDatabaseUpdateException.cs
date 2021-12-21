using Microsoft.EntityFrameworkCore;

namespace TP_Final.Excepciones
{
    public class EFDatabaseUpdateException : DbUpdateException
    {
        public EFDatabaseUpdateException(string pMensaje) : base(pMensaje) { }
    }
}

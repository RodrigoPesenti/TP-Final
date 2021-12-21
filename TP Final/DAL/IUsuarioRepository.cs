using TP_Final.Domain;

namespace TP_Final.DAL
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {

        public Usuario GetPorUsuario(string pNombreUsuario);

    }
}

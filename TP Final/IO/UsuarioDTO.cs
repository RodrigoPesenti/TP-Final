using TP_Final.Domain;

namespace TP_Final.IO
{
    public class UsuarioDTO
    {
        public string Nombre { get; set; }

        public int Puntos { get; set; }

        public TipoUsuario TipoUsuario { get; set; }

        public string Mail { get; set; }
    }
}

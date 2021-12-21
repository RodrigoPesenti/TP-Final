using System.Collections.Generic;
using TP_Final.IO;

namespace TP_Final.API
{
    interface IApiConsultasBiblioteca
    {
        public List<LibroDTO> Consultar(string pTitulo);
    }
}

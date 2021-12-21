using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.IO
{
    public class LibroDTO
    {
        public Int64 ISBN { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public int CantEjem { get; set; }

        public List<EjemplarDTO> Ejemplares { get; set; }
    }
}

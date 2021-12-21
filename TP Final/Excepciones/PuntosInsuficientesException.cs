using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.Excepciones
{
    public class PuntosInsuficientesException : Exception
    {
        public PuntosInsuficientesException(string pMensaje) : base(pMensaje) { }
    }
}

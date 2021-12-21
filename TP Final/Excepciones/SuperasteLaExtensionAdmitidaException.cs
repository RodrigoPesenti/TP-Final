using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final.Excepciones
{
    public class SuperasteLaExtensionAdmitidaException : Exception
    {
        public SuperasteLaExtensionAdmitidaException(string pMensaje) : base(pMensaje) { }
    }
}

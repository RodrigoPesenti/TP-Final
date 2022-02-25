using System;

namespace TP_Final.Excepciones
{
    public class PuntosInsuficientesException : Exception
    {
        public PuntosInsuficientesException(string pMensaje) : base(pMensaje) { }
    }
}

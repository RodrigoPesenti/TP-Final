using System;
using System.Runtime.Serialization;

namespace TP_Final.Excepciones
{
    [Serializable]
    public class EjemplarNoDisponibleException : Exception
    {
        public EjemplarNoDisponibleException()
        {
        }

        public EjemplarNoDisponibleException(string message) : base(message)
        {
        }

        public EjemplarNoDisponibleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EjemplarNoDisponibleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
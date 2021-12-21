using System;
using System.Runtime.Serialization;

namespace TP_Final
{
    [Serializable]
    public class ContraseñaIncorrectaException : Exception
    {
        public ContraseñaIncorrectaException()
        {
        }

        public ContraseñaIncorrectaException(string message) : base(message)
        {
        }

        public ContraseñaIncorrectaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ContraseñaIncorrectaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
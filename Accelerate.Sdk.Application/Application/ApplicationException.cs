using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Accelerate.Application
{
    /// <summary>
    /// Excepción que se produce por errores en la capa de aplicación.
    /// </summary>
    [Serializable]
    [ExcludeFromCodeCoverage]
    public class ApplicationException : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase.
        /// </summary>
        public ApplicationException() : base()
        {
        }
        /// <summary>
        /// Inicializa una nueva instancia de la clase.
        /// </summary>
        /// <param name="message">
        /// Mensaje que describe el error.
        /// </param>
        public ApplicationException(String message) : base(message)
        {
        }
        /// <summary>
        /// Inicializa una nueva instancia de la clase.
        /// </summary>
        /// <param name="message">
        /// Mensaje que describe el error.
        /// </param>
        /// <param name="innerException">
        /// Excepción que es la causa de la excepción actual.
        /// </param>
        public ApplicationException(String message, Exception innerException) : base(message, innerException)
        {
        }
        /// <summary>
        /// Inicializa una nueva instancia de la clase.
        /// </summary>
        /// <param name="serializationInfo">
        /// Datos serializados del objeto que hacen referencia a la excepción que se va a producir.
        /// </param>
        /// <param name="streamingContext">
        /// Información contextual sobre el origen o el destino.
        /// </param>
        protected ApplicationException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {
        }
    }
}

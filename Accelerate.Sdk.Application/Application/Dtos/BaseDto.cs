using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Accelerate.Application.Dtos
{
    /// <summary>
    /// Clase base para objetos de datos transferibles.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public abstract class BaseDto : IDto
    {
        private Boolean _disposed;

        /// <inheritdoc />
        public virtual Object Clone()
        {
            var type = this.GetType();
            var instance = Activator.CreateInstance(type);
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                var value = property.GetValue(this);

                try
                {
                    property.SetValue(instance, value);
                }
                catch
                {
                    continue;
                }
            }

            return instance;
        }
        /// <summary>
        /// Libera los recursos utilizados.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// Libera los recursos utilizados.
        /// </summary>
        /// <param name="disposing">
        /// Indica si el objeto ya está liberando los recursos utilizados.
        /// </param>
        protected virtual void Dispose(Boolean disposing)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(BaseDto));
            }

            _disposed = true;
        }
        /// <inheritdoc />
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            var properties = this.GetType()
                                 .GetProperties();

            foreach (var property in properties)
            {
                var value = property.GetValue(this);
                info.AddValue(property.Name, value);
            }
        }
    }
}

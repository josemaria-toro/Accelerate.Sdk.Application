using System;
using System.Diagnostics.CodeAnalysis;

namespace Accelerate.Application.Services
{
    /// <summary>
    /// Clase base para servicios de la capa de aplicación.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public abstract class BaseAppService : IAppService
    {
        private Boolean _disposed;

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
                throw new ObjectDisposedException(nameof(BaseAppService));
            }

            _disposed = true;
        }
    }
}

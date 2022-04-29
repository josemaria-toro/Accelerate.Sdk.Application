using System;
using System.Runtime.Serialization;

namespace Accelerate.Application.Dtos
{
    /// <summary>
    /// Contrato para objetos de datos transferibles.
    /// </summary>
    public interface IDto : IDisposable, ISerializable, ICloneable
    {
    }
}

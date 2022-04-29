using System;
using System.Diagnostics.CodeAnalysis;

namespace Accelerate.Application.Dtos
{
    [ExcludeFromCodeCoverage]
    public class MockDto1 : Dto
    {
        public String Property1 { get; set; }
        public Int32 Property2 { get; set; }
        public DateTime Property3 { get; set; }
        public String Property4 { get; set; }
        public TimeSpan Property5 { get; set; }
    }
}

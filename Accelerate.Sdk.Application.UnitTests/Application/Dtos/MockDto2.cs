using System;
using System.Diagnostics.CodeAnalysis;

namespace Accelerate.Application.Dtos
{
    [ExcludeFromCodeCoverage]
    public class MockDto2 : Dto
    {
        public String Property1 { get; set; }
        public Int32 Property2 { get; set; }
        public TimeSpan Property3 { get; set; }
        public TimeSpan? Property5 { get; set; }
        public String Property6 { get; set; }
    }
}

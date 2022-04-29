using Accelerate.Application.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Accelerate.Application.UnitTests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class IDtoExtensionsTest
    {
        [TestMethod]
        public void Build()
        {
            var dto1 = new MockDto1
            {
                Property1 = "lorem ipsum",
                Property2 = -1,
                Property3 = DateTime.UtcNow
            };

            var dto2 = dto1.Build<MockDto2>();

            Assert.IsTrue(dto1.Property1 == dto2.Property1);
            Assert.IsTrue(dto1.Property2 == dto2.Property2);
        }
        [TestMethod]
        public void BuildNullCheck()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                IDtoExtensions.Build<MockDto1>(null);
            });
        }
        [TestMethod]
        public void Map()
        {
            var dto1 = new MockDto1
            {
                Property1 = "lorem ipsum",
                Property2 = -1,
                Property3 = DateTime.UtcNow,
                Property4 = String.Empty
            };

            var dto2 = new MockDto2
            {
                Property1 = String.Empty,
                Property2 = Int32.MinValue,
                Property3 = TimeSpan.Zero
            };

            dto1.Map(dto2);

            Assert.IsTrue(dto1.Property1 == dto2.Property1);
            Assert.IsTrue(dto1.Property2 == dto2.Property2);
        }
        [TestMethod]
        public void MapNullCheck()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                IDtoExtensions.Map<MockDto2>(null, new MockDto2());
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                IDtoExtensions.Map<MockDto2>(new MockDto1(), null);
            });
        }
    }
}
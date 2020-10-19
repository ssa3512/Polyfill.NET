using System;
using Xunit;

namespace Polyfill.NET.RecordsTests
{
    public record TestRecord(int Value1, string Value2);

    public class RecordTypeTests
    {
        [Fact]
        public void RecordType_WithKeyword_WorksCorrectly()
        {
            var record = new TestRecord(2, "Hello");
            var record2 = record with { Value1 = 3 };

            Assert.Equal(record2, new TestRecord(3, "Hello"));

            var (val1, val2) = record2;
            Assert.Equal(3, val1);
            Assert.Equal("Hello", val2);
        }

        [Fact]
        public void RecordType_Deconstruction_WorksCorrectly()
        {
            var record = new TestRecord(2, "Hello");
            
            var (val1, val2) = record;
            Assert.Equal(2, val1);
            Assert.Equal("Hello", val2);
        }

        [Fact]
        public void RecordType_Equality_WorksCorrectly()
        {
            var record = new TestRecord(2, "Hello");
            var record2 = new TestRecord(2, "Hello");
            Assert.True(record == record2);
        }
    }
}

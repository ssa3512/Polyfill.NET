using System;
using Xunit;

namespace Polyfill.NET.RangesTests
{
    public class RangeTests
    {
        [Fact]
        public void Range_Subsection_Works()
        {
            var arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            var expected = new int[] { 3, 4, 5 };

            Assert.Equal(expected, arr1[2..5]);
        }

        [Fact]
        public void Index_Reverse_Works()
        {
            var arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Assert.Equal(7, arr1[^1]);
        }
    }
}
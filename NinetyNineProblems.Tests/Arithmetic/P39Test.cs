using System.Collections.Generic;
using NinetyNineProblems.Arithmetic;
using Xunit;

namespace NinetyNineProblems.Tests.Arithmetic
{
    public class P39Test
    {
        [Fact]
        public void ShouldReturn4PrimeNumbers()
        {
            var expectedList = new List<int> { 11, 13, 17, 19 };

            Assert.Equal(expectedList, P39.RrimesR(10, 20));
        }
    }
}
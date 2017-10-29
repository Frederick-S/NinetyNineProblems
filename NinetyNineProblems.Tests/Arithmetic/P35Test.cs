using System.Collections.Generic;
using NinetyNineProblems.Arithmetic;
using Xunit;

namespace NinetyNineProblems.Tests.Arithmetic
{
    public class P35Test
    {
        [Fact]
        public void ShouldReturn4PrimeFactors()
        {
            var expectedList = new List<int> { 3, 3, 5, 7 };

            Assert.Equal(4, P35.PrimeFactors(315).Count);
            Assert.Equal(expectedList, P35.PrimeFactors(315));
        }
    }
}
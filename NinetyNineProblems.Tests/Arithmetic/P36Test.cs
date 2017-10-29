using System;
using System.Collections.Generic;
using NinetyNineProblems.Arithmetic;
using Xunit;

namespace NinetyNineProblems.Tests.Arithmetic
{
    public class P36Test
    {
        [Fact]
        public void ShouldReturn3Groups()
        {
            var expectedList = new List<Tuple<int, int>>
            {
                Tuple.Create(3, 2),
                Tuple.Create(5, 1),
                Tuple.Create(7, 1),
            };

            Assert.Equal(expectedList, P36.PrimeFactorsMult(315));
        }
    }
}
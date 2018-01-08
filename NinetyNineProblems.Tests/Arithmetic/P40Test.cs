using System;
using System.Collections.Generic;
using NinetyNineProblems.Arithmetic;
using Xunit;

namespace NinetyNineProblems.Tests.Arithmetic
{
    public class P40Test
    {
        [Fact]
        public void ShouldReturn4PrimeNumbers()
        {
            List<Tuple<int, int>> expectedList = new List<Tuple<int, int>> { Tuple.Create(5, 23), Tuple.Create(11, 17) };

            Assert.Equal(expectedList, P40.GoldbachConjecture(28));
        }
    }
}
using System;
using NinetyNineProblems.Arithmetic;
using Xunit;

namespace NinetyNineProblems.Tests.Arithmetic
{
    public class P40Test
    {
        [Fact]
        public void ShouldReturn4PrimeNumbers()
        {
            Assert.Equal(Tuple.Create(5, 23), P40.GoldbachConjecture(28));
            Assert.Equal(Tuple.Create(3, 53), P40.GoldbachConjecture(56));
            Assert.Equal(Tuple.Create(7, 53), P40.GoldbachConjecture(60));
        }
    }
}
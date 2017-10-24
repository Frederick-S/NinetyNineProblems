using NinetyNineProblems.Arithmetic;
using Xunit;

namespace NinetyNineProblems.Tests.Arithmetic
{
    public class P31Test
    {
        [Fact]
        public void ShouldReturnFalseBecause1IsNotPrime()
        {
            Assert.False(P31.IsPrime(1));
        }

        [Fact]
        public void ShouldReturnTrueBecause2IsPrime()
        {
            Assert.True(P31.IsPrime(2));
        }

        [Fact]
        public void ShouldReturnTrueBecause7IsPrime()
        {
            Assert.True(P31.IsPrime(7));
        }

        [Fact]
        public void ShouldReturnTrueBecause61IsPrime()
        {
            Assert.True(P31.IsPrime(61));
        }

        [Fact]
        public void ShouldReturnFalseBecause100IsNotPrime()
        {
            Assert.False(P31.IsPrime(100));
        }

        [Fact]
        public void ShouldReturnFalseBecause125IsNotPrime()
        {
            Assert.False(P31.IsPrime(125));
        }
    }
}
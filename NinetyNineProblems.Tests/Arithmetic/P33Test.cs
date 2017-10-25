using NinetyNineProblems.Arithmetic;
using Xunit;

namespace NinetyNineProblems.Tests.Arithmetic
{
    public class P33Test
    {
        [Fact]
        public void ShouldReturnTrue()
        {
            Assert.True(P33.Coprime(35, 64));
        }

        [Fact]
        public void ShouldReturnFalse()
        {
            Assert.False(P33.Coprime(36, 63));
        }
    }
}
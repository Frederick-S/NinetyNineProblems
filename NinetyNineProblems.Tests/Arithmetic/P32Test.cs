using NinetyNineProblems.Arithmetic;
using Xunit;

namespace NinetyNineProblems.Tests.Arithmetic
{
    public class P32Test
    {
        [Fact]
        public void ShouldReturn9()
        {
            Assert.Equal(9, P32.GCD(36, 63));
        }

        [Fact]
        public void ShouldReturn3()
        {
            Assert.Equal(3, P32.GCD(-3, -6));
            Assert.Equal(3, P32.GCD(-3, 6));
        }
    }
}
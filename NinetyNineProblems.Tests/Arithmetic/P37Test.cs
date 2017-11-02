using NinetyNineProblems.Arithmetic;
using Xunit;

namespace NinetyNineProblems.Tests.Arithmetic
{
    public class P37Test
    {
        [Fact]
        public void ShouldReturn1()
        {
            Assert.Equal(1, P37.Phi(1));
        }

        [Fact]
        public void ShouldReturn4()
        {
            Assert.Equal(4, P37.Phi(10));
        }
    }
}
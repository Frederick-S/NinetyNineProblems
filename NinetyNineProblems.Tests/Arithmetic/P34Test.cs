using NinetyNineProblems.Arithmetic;
using Xunit;

namespace NinetyNineProblems.Tests.Arithmetic
{
    public class P34Test
    {
        [Fact]
        public void ShouldReturn1()
        {
            Assert.Equal(1, P34.TotientPhi(1));
        }

        [Fact]
        public void ShouldReturn4()
        {
            Assert.Equal(4, P34.TotientPhi(10));
        }
    }
}
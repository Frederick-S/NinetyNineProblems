using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P24Test
    {
        [Fact]
        public void ShouldDrawSixDifferentRandomNumbersFromOneToFortyNine()
        {
            var aaa = P24.RndSelect(6, 49);
            Assert.Equal(6, P24.RndSelect(6, 49).Count);
        }
    }
}
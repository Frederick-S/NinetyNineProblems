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
            var list = P24.RndSelect(6, 49);

            Assert.Equal(6, list.Count);

            foreach (int i in list)
            {
                Assert.True(1 <= 1 && i <= 49);
            }
        }
    }
}
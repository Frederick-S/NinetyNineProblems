using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P23Test
    {
        [Fact]
        public void ShouldExtractThreeRandomlySelectedElements()
        {
            var list = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

            Assert.Equal(3, P23.RndSelect(list, 3).Count);
        }
    }
}
using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P16Test
    {
        [Fact]
        public void ShouldDropEveryThirdElement()
        {
            var list = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'k' };
            var expectedList = new List<char> { 'a', 'b', 'd', 'e', 'g', 'h', 'k' };

            Assert.Equal(expectedList, P16.DropEvery(list, 3));
        }
    }
}
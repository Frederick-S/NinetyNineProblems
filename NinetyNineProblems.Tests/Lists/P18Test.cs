using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P18Test
    {
        [Fact]
        public void ShouldSliceListFromThreeToSeven()
        {
            var list = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'k' };
            var expectedList = new List<char> { 'c', 'd', 'e', 'f', 'g' };

            Assert.Equal(expectedList, P18.Slice(list, 3, 7));
        }
    }
}
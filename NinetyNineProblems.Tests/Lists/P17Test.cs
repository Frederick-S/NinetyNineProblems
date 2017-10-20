using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P17Test
    {
        [Fact]
        public void ShouldSplitListToTwoParts()
        {
            var list = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'k' };
            var expectedList = new List<List<char>>
            {
                new List<char> { 'a', 'b', 'c' },
                new List<char> { 'd', 'e', 'f', 'g', 'h', 'i', 'k' },
            };

            Assert.Equal(expectedList, P17.Split(list, 3));
        }
    }
}
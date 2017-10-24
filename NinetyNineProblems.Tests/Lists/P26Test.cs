using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P26Test
    {
        [Fact]
        public void ShouldReturnSixCombinations()
        {
            var list = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' };

            Assert.Equal(6, P26.Combinations(list, 1).Count);
        }

        [Fact]
        public void ShouldReturnTwentyCombinations()
        {
            var list = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' };

            Assert.Equal(20, P26.Combinations(list, 3).Count);
        }
    }
}
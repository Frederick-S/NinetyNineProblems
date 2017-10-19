using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P15Test
    {
        [Fact]
        public void ShouldReturnReplicatedList()
        {
            var list = new List<char> { 'a', 'b', 'c' };
            var expectedList = new List<char> { 'a', 'a', 'a', 'b', 'b', 'b', 'c', 'c', 'c' };

            Assert.Equal(expectedList, P15.Repli(list, 3));
        }
    }
}
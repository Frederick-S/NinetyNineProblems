using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P19Test
    {
        [Fact]
        public void ShouldReturnRotatedList()
        {
            var list = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            var expectedList = new List<char> { 'd', 'e', 'f', 'g', 'h', 'a', 'b', 'c' };

            Assert.Equal(expectedList, P19.Rotate(list, 3));

            expectedList = new List<char> { 'g', 'h', 'a', 'b', 'c', 'd', 'e', 'f' };

            Assert.Equal(expectedList, P19.Rotate(list, -2));
        }
    }
}
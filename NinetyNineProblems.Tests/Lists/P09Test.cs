using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P09Test
    {
        [Fact]
        public void ShouldReturnPackedList()
        {
            var list = new List<char> { 'a', 'a', 'a', 'a', 'b', 'c', 'c', 'a', 'a', 'd', 'e', 'e', 'e', 'e' };
            var expectedList = new List<List<char>>
            {
                 new List<char> { 'a', 'a', 'a', 'a' },
                 new List<char> { 'b' },
                 new List<char> { 'c', 'c' },
                 new List<char> { 'a', 'a' },
                 new List<char> { 'd' },
                 new List<char> { 'e', 'e', 'e', 'e' },
            };

            Assert.Equal(expectedList, P09.Pack(list));
        }
    }
}
using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P14Test
    {
        [Fact]
        public void ShouldDuplicateEveryElement()
        {
            var list = new List<char> { 'a', 'b', 'c', 'c', 'd' };
            var expectedList = new List<char> { 'a', 'a', 'b', 'b', 'c', 'c', 'c', 'c', 'd', 'd' };

            Assert.Equal(expectedList, P14.Dupli(list));
        }
    }
}
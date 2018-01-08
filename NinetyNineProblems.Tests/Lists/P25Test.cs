using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P25Test
    {
        [Fact]
        public void ShouldARandomPermutationOfList()
        {
            var list = P25.RndPermu(new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' });

            Assert.Equal(6, list.Count);

            foreach (var c in list)
            {
                Assert.Contains(c, list);
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P08Test
    {
        [Fact]
        public void ShouldEliminateConsecutiveDuplicates()
        {
            var list = "aaaabccaadeeee".ToCharArray()
                .OfType<char>()
                .Select(x => x.ToString())
                .ToList();

            Assert.Equal(new List<string> { "a", "b", "c", "a", "d", "e" }, P08.Compress(list));
        }
    }
}
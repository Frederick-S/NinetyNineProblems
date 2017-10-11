using System.Collections.Generic;
using System.Linq;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P05Test
    {
        [Fact]
        public void ShouldReturnReversedList()
        {
            var list = "A man, a plan, a canal, panama!".ToCharArray()
                .OfType<char>()
                .Select(c => c.ToString())
                .ToList();
            var expectedList = "!amanap ,lanac a ,nalp a ,nam A".ToCharArray()
                .OfType<char>()
                .Select(c => c.ToString())
                .ToList();

            Assert.Equal(expectedList, P05.MyReverse(list));
            Assert.Equal(new List<int> { 4, 3, 2, 1 }, P05.MyReverse2(new List<int> { 1, 2, 3, 4 }));
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P06Test
    {
        [Fact]
        public void ShouldReturnFalse()
        {
            Assert.False(P06.IsPalindrome(new List<int> { 1, 2, 3 }));
        }

        [Fact]
        public void ShouldReturnTrue()
        {
            var list = "madamimadam".ToCharArray()
                .OfType<char>()
                .Select(c => c.ToString())
                .ToList();

            Assert.True(P06.IsPalindrome(list));
            Assert.True(P06.IsPalindrome(new List<int> { 1, 2, 4, 8, 16, 8, 4, 2, 1 }));
        }
    }
}
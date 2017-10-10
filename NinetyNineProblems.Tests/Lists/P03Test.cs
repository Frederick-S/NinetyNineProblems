using System;
using System.Collections.Generic;
using System.Linq;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P03Test
    {
        [Fact]
        public void ShouldReturn2()
        {
            Assert.Equal(2, P03.ElementAt(new List<int> { 1, 2, 3 }, 2));
        }

        [Fact]
        public void ShouldReturnR()
        {
            var list = "csharp".ToCharArray()
                .OfType<char>()
                .Select(c => c.ToString())
                .ToList();

            Assert.Equal("r", P03.ElementAt(list, 5));
        }

        [Fact]
        public void ShouldThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => P03.ElementAt<int>(new List<int> { 1 }, 2));
        }
    }
}
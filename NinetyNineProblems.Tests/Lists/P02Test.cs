using System;
using System.Collections.Generic;
using System.Linq;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P02Test
    {
        [Fact]
        public void ShouldReturn3()
        {
            Assert.Equal(3, P02.MyButLast(new List<int> { 1, 2, 3, 4 }));
        }

        [Fact]
        public void ShouldReturnY()
        {
            var list = Enumerable.Range(0, 26)
                .Select(i => Convert.ToChar('a' + i).ToString())
                .ToList();

            Assert.Equal("y", P02.MyButLast(list));
        }

        [Fact]
        public void ShouldThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => P02.MyButLast<int>(new List<int> { 1 }));
        }
    }
}
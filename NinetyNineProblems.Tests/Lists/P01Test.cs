using System;
using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P01Test
    {
        [Fact]
        public void ShouldReturn4()
        {
            Assert.Equal(4, P01.MyLast(new List<int> { 1, 2, 3, 4 }));
        }

        [Fact]
        public void ShouldReturnZ()
        {
            Assert.Equal("z", P01.MyLast(new List<string> { "x", "y", "z" }));
        }

        [Fact]
        public void ShouldThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => P01.MyLast<int>(new List<int>()));
        }
    }
}
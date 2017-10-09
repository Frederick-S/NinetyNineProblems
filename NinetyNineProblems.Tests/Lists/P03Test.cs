using System;
using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P03Test
    {
        [Fact]
        public void Return3()
        {
            Assert.Equal(3, P03.ElementAt(new List<int> { 5, 4, 3, 2, 1 }, 3));
        }

        [Fact]
        public void ReturnWorld()
        {
            Assert.Equal("World", P03.ElementAt(new List<string> { "Hello", "World" }, 2));
        }

        [Fact]
        public void ThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => P03.ElementAt<int>(new List<int> { 1 }, 2));
        }
    }
}
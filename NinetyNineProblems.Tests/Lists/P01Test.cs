using System;
using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P01Test
    {
        [Fact]
        public void Return1()
        {
            Assert.Equal(1, P01.MyLast(new List<int> { 5, 4, 3, 2, 1 }));
        }

        [Fact]
        public void ReturnWorld()
        {
            Assert.Equal("World", P01.MyLast(new List<string> { "Hello", "World" }));
        }

        [Fact]
        public void ThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => P01.MyLast<int>(new List<int>()));
        }
    }
}
using System;
using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P02Test
    {
        [Fact]
        public void Return2()
        {
            Assert.Equal(2, P02.MyButLast(new List<int> { 5, 4, 3, 2, 1 }));
        }

        [Fact]
        public void ReturnHello()
        {
            Assert.Equal("Hello", P02.MyButLast(new List<string> { "Hello", "World" }));
        }

        [Fact]
        public void ThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => P02.MyButLast<int>(new List<int> { 1 }));
        }
    }
}
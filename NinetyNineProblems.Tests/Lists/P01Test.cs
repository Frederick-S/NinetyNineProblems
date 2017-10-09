using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P01Test
    {
        [Fact]
        public void Return1AsLastElement()
        {
            Assert.Equal(1, P01.MyLast(new List<int> { 5, 4, 3, 2, 1 }));
        }

        [Fact]
        public void ReturnWorldAsLastElement()
        {
            Assert.Equal("World", P01.MyLast(new List<string> { "Hello", "World" }));
        }
    }
}
using System;
using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P20Test
    {
        [Fact]
        public void ShouldRemoveTheSecondElement()
        {
            var list = new List<char> { 'a', 'b', 'c', 'd' };
            var expectedList = new List<char> { 'a', 'c', 'd' };

            Assert.Equal(expectedList, P20.RemoveAt(list, 2));
        }

        [Fact]
        public void ShouldThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => P20.RemoveAt(new List<int>(), 2));
        }
    }
}
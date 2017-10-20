using System;
using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P21Test
    {
        [Fact]
        public void ShouldInsertXAtPositionTwo()
        {
            var list = new List<char> { 'a', 'b', 'c', 'd' };
            var expectedList = new List<char> { 'a', 'X', 'b', 'c', 'd' };

            Assert.Equal(expectedList, P21.InsertAt(list, 'X', 2));
        }

        [Fact]
        public void ShouldThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => P21.InsertAt(new List<int>(), 'X', 2));
        }
    }
}
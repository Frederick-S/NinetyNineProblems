using System;
using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P05Test
    {
        [Fact]
        public void ReturnReversedList()
        {
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, P05.MyReverse(new List<int> { 5, 4, 3, 2, 1 }));
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, P05.MyReverse2(new List<int> { 5, 4, 3, 2, 1 }));
        }
    }
}
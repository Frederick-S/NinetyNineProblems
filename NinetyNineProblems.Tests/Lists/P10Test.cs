using System;
using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P10Test
    {
        [Fact]
        public void ShouldReturnEncodedList()
        {
            var list = new List<char> { 'a', 'a', 'a', 'a', 'b', 'c', 'c', 'a', 'a', 'd', 'e', 'e', 'e', 'e' };
            var expectedList = new List<Tuple<int, char>>
            {
                 Tuple.Create(4, 'a'),
                 Tuple.Create(1, 'b'),
                 Tuple.Create(2, 'c'),
                 Tuple.Create(2, 'a'),
                 Tuple.Create(1, 'd'),
                 Tuple.Create(4, 'e'),
            };

            Assert.Equal(expectedList, P10.Encode(list));
        }
    }
}
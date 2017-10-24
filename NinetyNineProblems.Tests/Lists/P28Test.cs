using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P28Test
    {
        [Fact]
        public void ShouldSortListBySubListLength()
        {
            var list = new List<List<char>>
            {
                new List<char> { 'a', 'b', 'c' },
                new List<char> { 'd', 'e' },
                new List<char> { 'f', 'g', 'h' },
                new List<char> { 'd', 'e' },
                new List<char> { 'i', 'j', 'k', 'l' },
                new List<char> { 'm', 'n' },
                new List<char> { 'o' },
            };
            var expectedList = new List<List<char>>
            {
                new List<char> { 'o' },
                new List<char> { 'd', 'e' },
                new List<char> { 'd', 'e' },
                new List<char> { 'm', 'n' },
                new List<char> { 'a', 'b', 'c' },
                new List<char> { 'f', 'g', 'h' },
                new List<char> { 'i', 'j', 'k', 'l' },
            };

            Assert.Equal(expectedList, P28.LSort(list));
        }

        [Fact]
        public void ShouldSortListBySubListLengthFrequency()
        {
            var list = new List<List<char>>
            {
                new List<char> { 'a', 'b', 'c' },
                new List<char> { 'd', 'e' },
                new List<char> { 'f', 'g', 'h' },
                new List<char> { 'd', 'e' },
                new List<char> { 'i', 'j', 'k', 'l' },
                new List<char> { 'm', 'n' },
                new List<char> { 'o' },
            };
            var expectedList = new List<List<char>>
            {
                new List<char> { 'i', 'j', 'k', 'l' },
                new List<char> { 'o' },
                new List<char> { 'a', 'b', 'c' },
                new List<char> { 'f', 'g', 'h' },
                new List<char> { 'd', 'e' },
                new List<char> { 'd', 'e' },
                new List<char> { 'm', 'n' },
            };

            Assert.Equal(expectedList, P28.LFsort(list));
        }
    }
}
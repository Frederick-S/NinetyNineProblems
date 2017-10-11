using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P07Test
    {
        [Fact]
        public void ShouldReturnFlattenedList()
        {
            var list = new List<object> { 1, new List<object> { 2, new List<object> { 3, 4 } }, 5 };

            Assert.Equal(new List<object> { 1, 2, 3, 4, 5 }, P07.Flatten(list));
        }

        [Fact]
        public void ShouldReturnAnEmptyList()
        {
            Assert.Equal(new List<object>(), P07.Flatten(new List<object>()));
        }
    }
}
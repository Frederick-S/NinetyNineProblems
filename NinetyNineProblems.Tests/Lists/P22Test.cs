using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P22Test
    {
        [Fact]
        public void ShouldReturnAnIntegerRangeFromFourToNine()
        {
            var expectedList = new List<int> { 4, 5, 6, 7, 8, 9 };

            Assert.Equal(expectedList, P22.Range(4, 9));
        }
    }
}
using System.Collections.Generic;
using NinetyNineProblems.LogicAndCodes;
using Xunit;

namespace NinetyNineProblems.Tests.LogicAndCodes
{
    public class P49Test
    {
        [Fact]
        public void ShouldReturnGrayCodes()
        {
            var expectedList = new List<string> { "000", "001", "011", "010", "110", "111", "101", "100" };

            Assert.Equal(expectedList, P49.Gray(3));
        }
    }
}
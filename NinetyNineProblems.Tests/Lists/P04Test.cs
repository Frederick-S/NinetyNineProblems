using System;
using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P04Test
    {
        [Fact]
        public void Return5()
        {
            Assert.Equal(5, P04.MyLength(new List<int> { 5, 4, 3, 2, 1 }));
        }
    }
}
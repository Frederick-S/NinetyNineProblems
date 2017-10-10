using System;
using System.Collections.Generic;
using System.Linq;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P04Test
    {
        [Fact]
        public void ShouldReturn3()
        {
            Assert.Equal(3, P04.MyLength(new List<int> { 123, 456, 789 }));
        }

        [Fact]
        public void ShouldReturn13()
        {
            var list = "Hello, world!".ToCharArray()
                .OfType<char>()
                .Select(c => c.ToString())
                .ToList();

            Assert.Equal(13, P04.MyLength(list));
        }
    }
}
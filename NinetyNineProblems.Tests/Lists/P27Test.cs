using System;
using System.Collections.Generic;
using NinetyNineProblems.Lists;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P27Test
    {
        [Fact]
        public void ShouldReturn1260Solutions()
        {
            var list = new List<string> { "aldo", "beat", "carla", "david", "evi", "flip", "gary", "hugo", "ida" };

            Assert.Equal(1260, P27.Group(list, Tuple.Create(2, 3, 4)).Count);
        }

        [Fact]
        public void ShouldReturn756Solutions()
        {
            var list = new List<string> { "aldo", "beat", "carla", "david", "evi", "flip", "gary", "hugo", "ida" };

            Assert.Equal(756, P27.Group(list, Tuple.Create(2, 2, 5)).Count);
        }
    }
}
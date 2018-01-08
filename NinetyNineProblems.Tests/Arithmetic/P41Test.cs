using System;
using System.Collections.Generic;
using NinetyNineProblems.Arithmetic;
using Xunit;

namespace NinetyNineProblems.Tests.Arithmetic
{
    public class P41Test
    {
        [Fact]
        public void ShouldReturnPrimePairs()
        {
            List<Tuple<int, int>> expectedList = new List<Tuple<int, int>>
            {
                 Tuple.Create(3, 7),
                 Tuple.Create(5, 5),
                 Tuple.Create(5, 7),
                 Tuple.Create(3, 11),
                 Tuple.Create(7, 7),
                 Tuple.Create(3, 13),
                 Tuple.Create(5, 11),
                 Tuple.Create(5, 13),
                 Tuple.Create(7, 11),
                 Tuple.Create(3, 17),
                 Tuple.Create(7, 13),
            };

            var result = P41.GoldbachList(9, 20);

            Assert.Equal(expectedList, P41.GoldbachList(9, 20));
        }
    }
}
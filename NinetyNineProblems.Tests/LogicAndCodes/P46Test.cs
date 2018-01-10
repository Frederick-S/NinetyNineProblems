using System;
using System.Collections.Generic;
using NinetyNineProblems.LogicAndCodes;
using Xunit;

namespace NinetyNineProblems.Tests.LogicAndCodes
{
    public class P46Test
    {
        [Fact]
        public void ShouldReturnTruthTable()
        {
            List<Tuple<bool, bool, bool>> expectedList = new List<Tuple<bool, bool, bool>>
            {
                Tuple.Create(true, true, true),
                Tuple.Create(true, false, true),
                Tuple.Create(false, true, false),
                Tuple.Create(false, false, false),
            };

            Assert.Equal(expectedList, P46.Table((bool a, bool b) => { return P46.And(a, P46.Or(a, b)); }));

            expectedList = new List<Tuple<bool, bool, bool>>
            {
                Tuple.Create(true, true, true),
                Tuple.Create(true, false, true),
                Tuple.Create(false, true, true),
                Tuple.Create(false, false, true),
            };

            Assert.Equal(expectedList, P46.Table((bool a, bool b) => { return P46.Nand(a, P46.Nor(a, b)); }));

            expectedList = new List<Tuple<bool, bool, bool>>
            {
                Tuple.Create(true, true, false),
                Tuple.Create(true, false, true),
                Tuple.Create(false, true, true),
                Tuple.Create(false, false, true),
            };

            Assert.Equal(expectedList, P46.Table((bool a, bool b) => { return P46.Xor(a, P46.Impl(a, b)); }));

            expectedList = new List<Tuple<bool, bool, bool>>
            {
                Tuple.Create(true, true, true),
                Tuple.Create(true, false, false),
                Tuple.Create(false, true, true),
                Tuple.Create(false, false, true),
            };

            Assert.Equal(expectedList, P46.Table((bool a, bool b) => { return P46.Impl(a, P46.Equ(a, b)); }));
        }
    }
}
using System;
using System.Collections.Generic;
using NinetyNineProblems.Lists;
using NinetyNineProblems.Lists.Helpers;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P12Test
    {
        [Fact]
        public void ShouldReturnDecodedModifiedList()
        {
            var list = new List<LengthEncodingElement<char>>
            {
                 new LengthEncodingElement<char> { ValueWithDuplicate = Tuple.Create(4, 'a') },
                 new LengthEncodingElement<char> { ValueWithoutDuplicate = 'b' },
                 new LengthEncodingElement<char> { ValueWithDuplicate = Tuple.Create(2, 'c') },
                 new LengthEncodingElement<char> { ValueWithDuplicate = Tuple.Create(2, 'a') },
                 new LengthEncodingElement<char> { ValueWithoutDuplicate = 'd' },
                 new LengthEncodingElement<char> { ValueWithDuplicate = Tuple.Create(4, 'e') },
            };
            var expectedList = new List<char> { 'a', 'a', 'a', 'a', 'b', 'c', 'c', 'a', 'a', 'd', 'e', 'e', 'e', 'e' };

            Assert.Equal(expectedList, P12.DecodeModified(list));
        }
    }
}
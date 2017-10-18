using System;
using System.Collections.Generic;
using System.Linq;
using NinetyNineProblems.Lists;
using NinetyNineProblems.Lists.Helpers;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P11Test
    {
        [Fact]
        public void ShouldReturnModifiedEncodedList()
        {
            var list = new List<char> { 'a', 'a', 'a', 'a', 'b', 'c', 'c', 'a', 'a', 'd', 'e', 'e', 'e', 'e' };
            var expectedList = new List<LengthEncodingElement<char>>
            {
                 new LengthEncodingElement<char> { ValueWithDuplicate = Tuple.Create(4, 'a') },
                 new LengthEncodingElement<char> { ValueWithoutDuplicate = 'b' },
                 new LengthEncodingElement<char> { ValueWithDuplicate = Tuple.Create(2, 'c') },
                 new LengthEncodingElement<char> { ValueWithDuplicate = Tuple.Create(2, 'a') },
                 new LengthEncodingElement<char> { ValueWithoutDuplicate = 'd' },
                 new LengthEncodingElement<char> { ValueWithDuplicate = Tuple.Create(4, 'e') },
            };
            var actualList = P11.EncodeModified(list);

            Enumerable.Range(0, expectedList.Count).ToList().ForEach(i =>
            {
                Assert.Equal(expectedList[i].ValueWithoutDuplicate, actualList[i].ValueWithoutDuplicate);
                Assert.Equal(expectedList[i].ValueWithDuplicate, actualList[i].ValueWithDuplicate);
            });
        }
    }
}
using System.Collections.Generic;
using NinetyNineProblems.Lists;
using NinetyNineProblems.Lists.Helpers;
using Xunit;

namespace NinetyNineProblems.Tests.Lists
{
    public class P07Test
    {
        [Fact]
        public void ShouldReturnFlattenedList()
        {
            var list = new List<NestedListElement<int>>
            {
                new NestedListElement<int> { Value = 1 },
                new NestedListElement<int>
                {
                    ListValue = new List<NestedListElement<int>>
                    {
                        new NestedListElement<int> { Value = 2 },
                        new NestedListElement<int>
                        {
                            ListValue = new List<NestedListElement<int>>
                            {
                                new NestedListElement<int> { Value = 3 },
                                new NestedListElement<int> { Value = 4 },
                            },
                        },
                    },
                },
                new NestedListElement<int> { Value = 5 },
            };

            Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, P07.Flatten(list));
        }

        [Fact]
        public void ShouldReturnAnEmptyList()
        {
            Assert.Equal(new List<int>(), P07.Flatten(new List<NestedListElement<int>>()));
        }
    }
}
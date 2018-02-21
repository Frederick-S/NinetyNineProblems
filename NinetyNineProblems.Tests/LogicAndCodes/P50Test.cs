using System;
using NinetyNineProblems.LogicAndCodes;
using Xunit;

namespace NinetyNineProblems.Tests.LogicAndCodes
{
    public class P50Test
    {
        [Fact]
        public void ShouldReturnHuffmanCodes()
        {
            Assert.Throws<NotImplementedException>(() => P50.Huffman(null));
        }
    }
}
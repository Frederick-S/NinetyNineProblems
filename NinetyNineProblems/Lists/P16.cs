using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P16
    {
        public static List<T> DropEvery<T>(List<T> list, int n)
        {
            return Enumerable.Range(1, list.Count)
                .Where(i => i % n != 0)
                .Select(i => list[i - 1])
                .ToList();
        }
    }
}
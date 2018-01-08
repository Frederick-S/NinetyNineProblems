using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P22
    {
        public static List<int> Range(int start, int end)
        {
            return Enumerable.Range(start, end - start + 1)
                .ToList();
        }
    }
}
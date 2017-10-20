using System;
using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P24
    {
        public static List<int> RndSelect(int count, int end)
        {
            int start = 1;
            Random random = new Random();

            return Enumerable.Range(start, end - start + 1)
                .OrderBy(i => random.Next())
                .Take(count)
                .ToList();
        }
    }
}
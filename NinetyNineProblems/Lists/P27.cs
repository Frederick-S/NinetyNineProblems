using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P27
    {
        public static List<List<List<T>>> Group<T>(List<T> list, Tuple<int, int, int> sizes)
        {
            Debug.Assert(list.Count == sizes.Item1 + sizes.Item2 + sizes.Item3, "List count should equal to sizes");

            return (from c1 in P26.Combinations(list, sizes.Item1)
                    from c2 in P26.Combinations(list.Except(c1).ToList(), sizes.Item2)
                    from c3 in P26.Combinations(list.Except(c1.Concat(c2)).ToList(), sizes.Item3)
                    select new List<List<T>> { c1, c2, c3 }).ToList();
        }
    }
}
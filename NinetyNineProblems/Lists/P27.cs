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

            return (from p1 in P26.Combinations(list, sizes.Item1)
                    from p2 in P26.Combinations(list.Except(p1).ToList(), sizes.Item2)
                    from p3 in P26.Combinations(list.Except(p1.Concat(p2)).ToList(), sizes.Item3)
                    select new List<List<T>> { p1, p2, p3 }).ToList();
        }
    }
}
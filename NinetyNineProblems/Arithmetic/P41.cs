using System;
using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Arithmetic
{
    public class P41
    {
        public static List<Tuple<int, int>> GoldbachList(int m, int n)
        {
            var evenNumbers = Enumerable.Range(m, n - m + 1).Where(i => i % 2 == 0).ToList();

            return evenNumbers.Select(i => P40.GoldbachConjecture(i))
                .SelectMany(list => list)
                .ToList();
        }
    }
}
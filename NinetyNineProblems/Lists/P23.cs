using System;
using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P23
    {
        public static List<T> RndSelect<T>(List<T> list, int n)
        {
            Random random = new Random();

            return Enumerable.Range(1, n)
                .Select(i => list[random.Next(0, list.Count)])
                .ToList();
        }
    }
}
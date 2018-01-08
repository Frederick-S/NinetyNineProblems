using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace NinetyNineProblems.Arithmetic
{
    public class P39
    {
        public static List<int> RrimesR(int m, int n)
        {
            Debug.Assert(m <= n, "m should be smaller than n");

            return Enumerable.Range(m, n - m + 1)
                .Where(x => P31.IsPrime(x))
                .ToList();
        }
    }
}
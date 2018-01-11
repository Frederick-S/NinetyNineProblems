using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace NinetyNineProblems.Arithmetic
{
    public class P40
    {
        public static List<Tuple<int, int>> GoldbachConjecture(int n)
        {
            Debug.Assert(n > 2 && n % 2 == 0, "n must be a positive even number greater than 2");

            var primes = Enumerable.Range(3, n - 3).Where(i => P31.IsPrime(i)).ToList();

            var primesSet1 = new HashSet<int>(primes);
            var primesSet2 = new HashSet<int>(primes);

            return primesSet1.Where(i => primesSet2.Contains(n - i) && i <= n - i)
                .Select(i => Tuple.Create(i, n - i))
                .ToList();
        }
    }
}
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

            List<int> primes = Enumerable.Range(3, n - 3).Where(i => P31.IsPrime(i)).ToList();
            List<int> primes2 = primes.Select(i => i).ToList();

            HashSet<int> primesSet1 = new HashSet<int>(primes);
            HashSet<int> primesSet2 = new HashSet<int>(primes2);
            List<Tuple<int, int>> groups = new List<Tuple<int, int>>();

            foreach (int number in primesSet1)
            {
                if (primesSet2.Contains(n - number) && number <= n - number)
                {
                    groups.Add(Tuple.Create(number, n - number));
                }
            }

            return groups;
        }
    }
}
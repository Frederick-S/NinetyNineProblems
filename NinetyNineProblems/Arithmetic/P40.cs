using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace NinetyNineProblems.Arithmetic
{
    public class P40
    {
        public static Tuple<int, int> GoldbachConjecture(int n)
        {
            Debug.Assert(n > 2 && n % 2 == 0, "n must be a positive even number greater than 2");

            List<int> primes = Enumerable.Range(3, n - 3).Where(i => P31.IsPrime(i)).ToList();
            List<int> primes2 = primes.Select(i => i).ToList();

            return TwoSum(primes, primes2, n);
        }

        private static Tuple<int, int> TwoSum(List<int> numbers1, List<int> numbers2, int sum)
        {
            HashSet<int> numberSet1 = new HashSet<int>(numbers1);
            HashSet<int> numberSet2 = new HashSet<int>(numbers2);

            foreach (int n in numberSet1)
            {
                if (numberSet2.Contains(sum - n))
                {
                    return Tuple.Create(n, sum - n);
                }
            }

            return Tuple.Create(-1, -1);
        }
    }
}
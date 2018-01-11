using System;
using System.Collections.Generic;

namespace NinetyNineProblems.Arithmetic
{
    public class P35
    {
        public static List<int> PrimeFactors(int n)
        {
            var primeFactors = new List<int>();

            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                while (n % i == 0)
                {
                    primeFactors.Add(i);

                    n /= i;
                }
            }

            if (n > 1)
            {
                primeFactors.Add(n);
            }

            return primeFactors;
        }
    }
}
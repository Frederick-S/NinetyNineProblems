using System;
using System.Collections.Generic;
using System.Linq;
using NinetyNineProblems.Lists.Helpers;

namespace NinetyNineProblems.Arithmetic
{
    public class P36
    {
        public static List<Tuple<int, int>> PrimeFactorsMult(int n)
        {
            return P35.PrimeFactors(n)
                .GroupWhile((previous, current) => previous == current)
                .Select(x => Tuple.Create(x.First(), x.Count()))
                .ToList();
        }
    }
}
using System;
using System.Linq;

namespace NinetyNineProblems.Arithmetic
{
    public class P37
    {
        public static int Phi(int m)
        {
            return P36.PrimeFactorsMult(m)
                .Aggregate(1, (accumulator, x) => accumulator * ((x.Item1 - 1) * (int)Math.Pow(x.Item1, x.Item2 - 1)));
        }
    }
}
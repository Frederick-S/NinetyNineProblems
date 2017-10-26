using System.Diagnostics;
using System.Linq;

namespace NinetyNineProblems.Arithmetic
{
    public class P34
    {
        public static int TotientPhi(int m)
        {
            Debug.Assert(m >= 1, "The input number should be greater than 1");

            if (m == 1)
            {
                return 1;
            }

            return Enumerable.Range(1, m - 1).Where(i => P33.Coprime(i, m)).Count();
        }
    }
}
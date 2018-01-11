using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.LogicAndCodes
{
    public class P49
    {
        public static List<string> Gray(int n)
        {
            if (n == 1)
            {
                return new List<string> { "0", "1" };
            }

            return (from a in Gray(1) from b in Gray(n - 1) select a + b).ToList();
        }
    }
}
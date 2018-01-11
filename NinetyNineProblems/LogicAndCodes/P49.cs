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

            var list = Gray(n - 1);
            var reversed = new List<string>(list);

            reversed.Reverse();

            return Enumerable.Concat(list.Select(x => "0" + x).ToList(), new List<string>(reversed).Select(x => "1" + x).ToList()).ToList();
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P19
    {
        public static List<T> Rotate<T>(List<T> list, int n)
        {
            if (n >= 0)
            {
                return Enumerable.Concat(list.GetRange(n, list.Count - n), list.Take(n)).ToList();
            }
            else
            {
                return Enumerable.Concat(list.GetRange(list.Count + n, -n), list.Take(list.Count + n)).ToList();
            }
        }
    }
}
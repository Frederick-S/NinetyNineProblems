using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P15
    {
        public static List<T> Repli<T>(List<T> list, int count)
        {
            return list.SelectMany(x => Enumerable.Repeat(x, count)).ToList();
        }
    }
}
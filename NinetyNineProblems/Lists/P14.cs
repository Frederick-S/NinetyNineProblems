using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P14
    {
        public static List<T> Dupli<T>(List<T> list)
        {
            return list.SelectMany(x => Enumerable.Repeat(x, 2))
                .ToList();
        }
    }
}
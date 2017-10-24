using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P16
    {
        public static List<T> DropEvery<T>(List<T> list, int n)
        {
            return list.Where((x, i) => (i + 1) % n != 0).ToList();
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P17
    {
        public static List<List<T>> Split<T>(List<T> list, int n)
        {
            return new List<List<T>> { list.Take(n).ToList(), list.GetRange(n, list.Count - n) };
        }
    }
}
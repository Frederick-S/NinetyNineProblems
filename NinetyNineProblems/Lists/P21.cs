using System.Collections.Generic;

namespace NinetyNineProblems.Lists
{
    public class P21
    {
        public static List<T> InsertAt<T>(List<T> list, T item, int n)
        {
            list.Insert(n - 1, item);

            return list;
        }
    }
}
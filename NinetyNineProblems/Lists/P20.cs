using System.Collections.Generic;

namespace NinetyNineProblems.Lists
{
    public class P20
    {
        public static List<T> RemoveAt<T>(List<T> list, int n)
        {
            list.RemoveAt(n - 1);

            return list;
        }
    }
}
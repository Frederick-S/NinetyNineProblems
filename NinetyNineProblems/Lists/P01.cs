using System.Collections.Generic;

namespace NinetyNineProblems.Lists
{
    public class P01
    {
        public static T MyLast<T>(List<T> list)
        {
            return list[list.Count - 1];
        }
    }
}
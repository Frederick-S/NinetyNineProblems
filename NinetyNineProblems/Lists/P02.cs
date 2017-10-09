using System.Collections.Generic;

namespace NinetyNineProblems.Lists
{
    public class P02
    {
        public static T MyButLast<T>(List<T> list)
        {
            return list[list.Count - 2];
        }
    }
}
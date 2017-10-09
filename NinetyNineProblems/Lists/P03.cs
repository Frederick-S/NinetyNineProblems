using System.Collections.Generic;

namespace NinetyNineProblems.Lists
{
    public class P03
    {
        public static T ElementAt<T>(List<T> list, int index)
        {
            return list[index - 1];
        }
    }
}
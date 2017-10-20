using System.Collections.Generic;

namespace NinetyNineProblems.Lists
{
    public class P18
    {
       public static List<T> Slice<T>(List<T> list, int start, int end)
       {
           return list.GetRange(start - 1, end - start + 1);
       }
    }
}
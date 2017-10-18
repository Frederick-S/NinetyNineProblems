using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P08
    {
        public static List<T> Compress<T>(List<T> list)
        {
            return CompressInternal(list, 0);
        }

        private static List<T> CompressInternal<T>(List<T> list, int index)
        {
            if (index == list.Count)
            {
                return new List<T>();
            }
            else if (index != 0 && list[index].Equals(list[index - 1]))
            {
                return CompressInternal(list, index + 1);
            }
            else
            {
                return new List<T> { list[index] }.Concat(CompressInternal(list, index + 1)).ToList();
            }
        }
    }
}
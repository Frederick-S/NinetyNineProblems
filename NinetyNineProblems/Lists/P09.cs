using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P09
    {
        public static List<List<T>> Pack<T>(List<T> list)
        {
            return PackInternal(list, 0);
        }

        private static List<List<T>> PackInternal<T>(List<T> list, int index)
        {
            if (index == list.Count)
            {
                return new List<List<T>>();
            }
            else if (index != list.Count - 1 && list[index].Equals(list[index + 1]))
            {
                var left = PackInternal(list, index + 1);

                return left.Select((x, i) =>
                    {
                        return i == 0 ? new List<T> { list[index] }.Concat(left[0]).ToList() : x;
                    }).ToList();
            }
            else
            {
                return new List<List<T>> { new List<T> { list[index] } }.Concat(PackInternal(list, index + 1)).ToList();
            }
        }
    }
}
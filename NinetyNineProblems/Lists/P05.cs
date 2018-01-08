using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P05
    {
        public static List<T> MyReverse<T>(List<T> list)
        {
            list.Reverse();

            return list;
        }

        public static List<T> MyReverse2<T>(List<T> list)
        {
            var middle = list.Count / 2;

            if (middle == 0)
            {
                return new List<T>(list);
            }

            var part1 = MyReverse2(list.GetRange(0, middle));
            var part2 = MyReverse2(list.GetRange(middle, list.Count - middle));

            return part2.Concat(part1)
                .ToList();
        }
    }
}
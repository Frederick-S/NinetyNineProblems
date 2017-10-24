using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P26
    {
        public static List<List<T>> Combinations<T>(List<T> list, int k)
        {
            if (k == 1)
            {
                return list.Select(x => new List<T> { x }).ToList();
            }
            else
            {
                return list.SelectMany((e, i) =>
                    {
                        return Combinations(list.Skip(i + 1).ToList(), k - 1)
                            .Select(c => new List<T> { e }.Concat(c).ToList());
                    })
                    .ToList();
            }
        }
    }
}
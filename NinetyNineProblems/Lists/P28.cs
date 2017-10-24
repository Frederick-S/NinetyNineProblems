using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P28
    {
        public static List<List<T>> LSort<T>(List<List<T>> list)
        {
            list.Sort((a, b) => a.Count - b.Count);

            return list;
        }

        public static List<List<T>> LFsort<T>(List<List<T>> list)
        {
            return list.Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Value.Count)
                .OrderBy(x => x.Count())
                .ThenBy(x => x.First().Index)
                .SelectMany(x => x.Select(y => y.Value).ToList())
                .ToList();
        }
    }
}
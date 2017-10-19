using System;
using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists.Helpers
{
    public static class GroupWhileHelper
    {
        public static IEnumerable<IEnumerable<T>> GroupWhile<T>(this IEnumerable<T> source, Func<T, T, bool> predicate)
        {
            using (var iterator = source.GetEnumerator())
            {
                if (!iterator.MoveNext())
                {
                    yield break;
                }

                List<T> currentGroup = new List<T>() { iterator.Current };

                while (iterator.MoveNext())
                {
                    if (predicate(currentGroup.Last(), iterator.Current))
                    {
                        currentGroup.Add(iterator.Current);
                    }
                    else
                    {
                        yield return currentGroup;

                        currentGroup = new List<T>() { iterator.Current };
                    }
                }

                yield return currentGroup;
            }
        }
    }
}
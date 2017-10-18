using System.Collections.Generic;
using System.Linq;
using NinetyNineProblems.Lists.Helpers;

namespace NinetyNineProblems.Lists
{
    public class P07
    {
        public static List<T> Flatten<T>(List<NestedListElement<T>> list)
        {
            return list.SelectMany(x =>
                {
                    if (x.ListValue != null)
                    {
                        return Flatten(x.ListValue);
                    }
                    else
                    {
                        return new List<T> { x.Value };
                    }
                })
                .ToList();
        }
    }
}
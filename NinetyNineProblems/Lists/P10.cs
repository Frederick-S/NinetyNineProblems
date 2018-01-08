using System;
using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P10
    {
        public static List<Tuple<int, T>> Encode<T>(List<T> list)
        {
            return P09.Pack(list)
                .Select(x => Tuple.Create(x.Count, x[0]))
                .ToList();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P25
    {
        public static List<T> RndPermu<T>(List<T> list)
        {
            Random random = new Random();

            return list.OrderBy(x => random.Next())
                .ToList();
        }
    }
}
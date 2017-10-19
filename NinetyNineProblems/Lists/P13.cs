using System;
using System.Collections.Generic;
using System.Linq;
using NinetyNineProblems.Lists.Helpers;

namespace NinetyNineProblems.Lists
{
    public class P13
    {
        public static List<LengthEncodingElement<T>> EncodeDirect<T>(List<T> list)
        {
            return list.GroupWhile((previous, next) => previous.Equals(next))
                .Select(x =>
                {
                    if (x.Count() == 1)
                    {
                        return new LengthEncodingElement<T> { ValueWithoutDuplicate = x.ToList()[0] };
                    }
                    else
                    {
                        return new LengthEncodingElement<T> { ValueWithDuplicate = Tuple.Create(x.Count(), x.ToList()[0]) };
                    }
                }).ToList();
        }
    }
}
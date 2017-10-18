using System;
using System.Collections.Generic;
using System.Linq;
using NinetyNineProblems.Lists.Helpers;

namespace NinetyNineProblems.Lists
{
    public class P11
    {
        public static List<LengthEncodingElement<T>> EncodeModified<T>(List<T> list)
        {
            return P09.Pack(list)
                .Select(x =>
                {
                    if (x.Count > 1)
                    {
                        return new LengthEncodingElement<T> { ValueWithDuplicate = Tuple.Create(x.Count, x[0]) };
                    }
                    else
                    {
                        return new LengthEncodingElement<T> { ValueWithoutDuplicate = x[0] };
                    }
                })
                .ToList();
        }
    }
}
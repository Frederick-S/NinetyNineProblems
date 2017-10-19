using System.Collections.Generic;
using System.Linq;
using NinetyNineProblems.Lists.Helpers;

namespace NinetyNineProblems.Lists
{
    public class P12
    {
        public static List<T> DecodeModified<T>(List<LengthEncodingElement<T>> list)
        {
            return list.SelectMany(x =>
                {
                    if (x.ValueWithDuplicate != null)
                    {
                        return Enumerable.Repeat(x.ValueWithDuplicate.Item2, x.ValueWithDuplicate.Item1).ToList();
                    }
                    else
                    {
                        return new List<T> { x.ValueWithoutDuplicate };
                    }
                }).ToList();
        }
    }
}
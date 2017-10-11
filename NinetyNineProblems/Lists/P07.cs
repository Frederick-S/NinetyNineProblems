using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.Lists
{
    public class P07
    {
        public static List<object> Flatten(List<object> list)
        {
            return list.SelectMany(x =>
                {
                    if (x is List<object>)
                    {
                        return Flatten(x as List<object>);
                    }
                    else
                    {
                        return new List<object> { x };
                    }
                })
                .ToList();
        }
    }
}
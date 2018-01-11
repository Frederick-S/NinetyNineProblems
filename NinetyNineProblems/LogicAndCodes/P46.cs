using System;
using System.Collections.Generic;
using System.Linq;

namespace NinetyNineProblems.LogicAndCodes
{
    public class P46
    {
        public static List<Tuple<bool, bool, bool>> Table(Func<bool, bool, bool> expression)
        {
            var combinations = (
                from a in new List<bool> { true, false }
                from b in new List<bool> { true, false }
                select Tuple.Create(a, b)).ToList();

            return combinations.Select(x => Tuple.Create(x.Item1, x.Item2, expression.Invoke(x.Item1, x.Item2)))
                .ToList();
        }

        public static bool And(bool a, bool b)
        {
            return a && b;
        }

        public static bool Or(bool a, bool b)
        {
            return a || b;
        }

        public static bool Nand(bool a, bool b)
        {
            return !(a && b);
        }

        public static bool Nor(bool a, bool b)
        {
            return !(a || b);
        }

        public static bool Xor(bool a, bool b)
        {
            return a ^ b;
        }

        public static bool Impl(bool a, bool b)
        {
            return !a || b;
        }

        public static bool Equ(bool a, bool b)
        {
            return a == b;
        }
    }
}
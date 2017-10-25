using System;

namespace NinetyNineProblems.Arithmetic
{
    public class P32
    {
        public static int GCD(int a, int b)
        {
            return GCDInternal(Math.Abs(a), Math.Abs(b));
        }

        private static int GCDInternal(int a, int b)
        {
            return b == 0 ? a : GCDInternal(b, a % b);
        }
    }
}
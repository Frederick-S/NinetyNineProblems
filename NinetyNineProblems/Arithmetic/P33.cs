namespace NinetyNineProblems.Arithmetic
{
    public class P33
    {
        public static bool Coprime(int a, int b)
        {
            return P32.GCD(a, b) == 1;
        }
    }
}
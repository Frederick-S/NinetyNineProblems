using System.Collections.Generic;

namespace NinetyNineProblems.Lists
{
    public class P06
    {
        public static bool IsPalindrome<T>(List<T> list)
        {
            return IsPalindromeInternal(list, 0, list.Count - 1);
        }

        private static bool IsPalindromeInternal<T>(List<T> list, int low, int high)
        {
            if (low >= high)
            {
                return true;
            }

            return list[low].Equals(list[high]) && IsPalindromeInternal(list, low + 1, high - 1);
        }
    }
}
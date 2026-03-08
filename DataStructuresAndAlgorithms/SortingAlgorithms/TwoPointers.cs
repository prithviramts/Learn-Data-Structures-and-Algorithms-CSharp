using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class TwoPointers
    {
        public static int StrStr(string haystack, string needle) // sad - right = 2
        {
            int left = 0;
            int right = needle.Length - 1;

            while (left < right)
            {

            }

            return -1;
        }

        public static bool ValidPalindrome (string s) // a , man ! gnam , a
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                char l = s[left];
                l = char.ToLower(l);
                char r = s[right];
                r = char.ToLower(r);
                if (!char.IsLetterOrDigit(l))
                {
                    left++;
                    continue;
                }
                if (!char.IsLetterOrDigit(r))
                {
                    right--;
                    continue;
                }
                if (l != r)
                {
                    return false;
                }
                else
                {
                    left++;
                    right--;
                }
            } 
            return true;
        }
    }
}

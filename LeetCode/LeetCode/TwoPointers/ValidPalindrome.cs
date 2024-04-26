using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

 

Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.

Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.

Example 3:

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.

 

Constraints:

    1 <= s.length <= 2 * 105
    s consists only of printable ASCII characters.

*/
namespace LeetCode.TwoPointers
{
    internal class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            s = Regex.Replace(s.ToLower(), "[^a-z0-9]", string.Empty);
            int half = s.Length / 2;
            bool result = true;

            for (int i = 0; i < half; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    result = false;
                    break;
                }
            }

            return result;

        }
    }
}

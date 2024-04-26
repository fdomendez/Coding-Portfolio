using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

 

Example 1:

Input: s = "anagram", t = "nagaram"
Output: true

Example 2:

Input: s = "rat", t = "car"
Output: false

 

Constraints:

    1 <= s.length, t.length <= 5 * 104
    s and t consist of lowercase English letters.

 

Follow up: What if the inputs contain Unicode characters? How would you adapt your solution to such a case?
*/

namespace LeetCode.Hashmap
{
    internal class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {

            //s = "aacc";
            //t = "ccac";

            if (s.Length != t.Length)
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                //Console.WriteLine("char->" + c);

                int index = t.IndexOf(c);

                if (index >= 0)
                {
                    s = s.Remove(i, 1);
                    t = t.Remove(index, 1);

                    i--;

                    //Console.WriteLine(s);
                    //Console.WriteLine(t);

                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}

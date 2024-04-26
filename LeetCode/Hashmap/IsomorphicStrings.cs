using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Given two strings s and t, determine if they are isomorphic.

Two strings s and t are isomorphic if the characters in s can be replaced to get t.

All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.

 

Example 1:

Input: s = "egg", t = "add"
Output: true

Example 2:

Input: s = "foo", t = "bar"
Output: false

Example 3:

Input: s = "paper", t = "title"
Output: true

 

Constraints:

    1 <= s.length <= 5 * 104
    t.length == s.length
    s and t consist of any valid ascii character.

*/
namespace LeetCode.Hashmap
{
    internal class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {

            Dictionary<string, char> pairs = new Dictionary<string, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (pairs.TryGetValue(s[i], out char value))
                {
                    if (value != t[i])
                    {
                        return false;
                    }
                }
                else
                {
                    pairs.Add(s[i] + t[i], s[i]);
                }
            }

            return true;
        }
    }
}

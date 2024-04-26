using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

 

Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false

Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false

Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true

 

Constraints:

    1 <= ransomNote.length, magazine.length <= 105
    ransomNote and magazine consist of lowercase English letters
*/
namespace LeetCode.Hashmap
{
    internal class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {

            if (ransomNote.Length <= magazine.Length)
            {
                for (int i = 0; i < ransomNote.Length; i++)
                {
                    int pos = magazine.IndexOf(ransomNote[i]);
                    if (pos >= 0)
                    {
                        magazine = magazine.Remove(pos, 1);
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            {
                return false;
            }

        }
    }
}

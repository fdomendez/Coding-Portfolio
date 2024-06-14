﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

 

Example 1:

Input: s = "abc", t = "ahbgdc"
Output: true

Example 2:

Input: s = "axc", t = "ahbgdc"
Output: false

 

Constraints:

    0 <= s.length <= 100
    0 <= t.length <= 104
    s and t consist only of lowercase English letters.

 
Follow up: Suppose there are lots of incoming s, say s1, s2, ..., sk where k >= 109, and you want to check one by one to see if t has its subsequence. In this scenario, how would you change your code?
*/
namespace LeetCode.TwoPointers
{
    internal class IsSubsequence
    {
        public bool Issubsequence(string s, string t)
        {

            for (int i = 0; i < s.Length; i++)
            {
                int indexFound = t.IndexOf(s[i]);
                if (indexFound >= 0)
                {
                    if (indexFound + 1 < t.Length)
                    {
                        t = t.Substring(indexFound + 1, t.Length - indexFound - 1);
                        Console.WriteLine(t);
                    }
                    else
                    {
                        t = "";
                    }
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

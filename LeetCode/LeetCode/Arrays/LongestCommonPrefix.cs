using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"

Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.

 

Constraints:

    1 <= strs.length <= 200
    0 <= strs[i].length <= 200
    strs[i] consists of only lowercase English letters.


41935179
*/

namespace LeetCode.Arrays
{
    internal class LongestCommonPrefix
    {
        public string LongestcommonPrefix(string[] strs)
        {

            int index = 0;
            string result = "";

            bool continuar = true;

            while (continuar)
            {
                char c = '\0';
                for (int i = 0; i < strs.Count(); i++)
                {
                    if (index < strs[i].Length)
                    {
                        if (c == '\0')
                        {
                            c = strs[i][index];
                        }
                        else if (c != strs[i][index])
                        {
                            c = '\0';
                            continuar = false;
                            break;
                        }
                    }
                    else
                    {
                        c = '\0';
                        continuar = false;
                        break;

                    }
                }
                if (c != '\0')
                {
                    result += c;
                }

                index++;
            }
            return result;

        }
    }
}

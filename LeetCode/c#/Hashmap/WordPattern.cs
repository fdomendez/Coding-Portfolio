using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Given a pattern and a string s, find if s follows the same pattern.

Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.

 

Example 1:

Input: pattern = "abba", s = "dog cat cat dog"
Output: true

Example 2:

Input: pattern = "abba", s = "dog cat cat fish"
Output: false

Example 3:

Input: pattern = "aaaa", s = "dog cat cat dog"
Output: false

 

Constraints:

    1 <= pattern.length <= 300
    pattern contains only lower-case English letters.
    1 <= s.length <= 3000
    s contains only lowercase English letters and spaces ' '.
    s does not contain any leading or trailing spaces.
    All the words in s are separated by a single space.

*/
namespace LeetCode.Hashmap
{
    internal class WordPattern
    {
        public bool Wordpattern(string pattern, string s)
        {
            Dictionary<char, string> dic = new Dictionary<char, string>();

            string[] words = s.Split(" ");

            //Console.WriteLine("length->" + pattern.Length + "Count ->" + words.Count());

            if (pattern.Length == words.Count())
            {

                for (int i = 0; i < pattern.Length; i++)
                {
                    char p = pattern[i];
                    string word = words[i];

                    //Console.WriteLine("p->" + p + " Word->" + word);

                    if (dic.ContainsKey(p))
                    {
                        if (dic.TryGetValue(p, out string val))
                        {
                            if (!val.Equals(word))
                            {
                                return false;
                            }
                        }

                    }
                    else
                    {
                        KeyValuePair<char, string> var = dic.FirstOrDefault(x => x.Value == word);

                        if (var.Value == word)
                        {
                            return false;
                        }
                        else
                        {
                            //Console.WriteLine("p->" + p + "Word->" + word);
                            dic.Add(p, word);
                        }

                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}

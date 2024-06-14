using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

    Open brackets must be closed by the same type of brackets.
    Open brackets must be closed in the correct order.
    Every close bracket has a corresponding open bracket of the same type.

 

Example 1:

Input: s = "()"
Output: true

Example 2:

Input: s = "()[]{}"
Output: true

Example 3:

Input: s = "(]"
Output: false

 

Constraints:

    1 <= s.length <= 104
    s consists of parentheses only '()[]{}'.

*/
namespace LeetCode.Stack
{
    internal class ValidParentheses
    {
        public bool IsValid(string s)
        {

            Stack<char> stack = new Stack<char>();

            stack.Push(s[0]);

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == ')')
                {
                    if (stack.Count() > 0 && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }

                }
                else if (s[i] == '}')
                {
                    if (stack.Count() > 0 && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (s[i] == ']')
                {
                    if (stack.Count() > 0 && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if ((i + 1) < s.Length)
                    {
                        stack.Push(s[i]);
                    }
                    else
                    {
                        return false;
                    }

                }
            }

            if (stack.Count() > 0) return false;

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write an algorithm to determine if a number n is happy.

A happy number is a number defined by the following process:

    Starting with any positive integer, replace the number by the sum of the squares of its digits.
    Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
    Those numbers for which this process ends in 1 are happy.

Return true if n is a happy number, and false if not.

 

Example 1:

Input: n = 19
Output: true
Explanation:
12 + 92 = 82
82 + 22 = 68
62 + 82 = 100
12 + 02 + 02 = 1

Example 2:

Input: n = 2
Output: false

 

Constraints:

    1 <= n <= 231 - 1

*/
namespace LeetCode.Hashmap
{
    internal class HappyNumber
    {
        public bool IsHappy(int n)
        {

            HashSet<int> st = new HashSet<int>();

            while (true)
            {
                //if(n < 10) return false;

                List<int> list = n.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).ToList();

                int result = 0;

                foreach (int i in list)
                {
                    result += i * i;
                }

                if (result == 1)
                {
                    return true;
                }
                else
                {
                    if (st.Contains(result))
                    {
                        return false;
                    }
                    else
                    {
                        n = result;
                        st.Add(result);
                    }
                }
            }
        }
    }
}

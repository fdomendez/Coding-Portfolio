/*
Given an array of positive integers nums and a positive integer target, return the minimal length of a
subarray
whose sum is greater than or equal to target. If there is no such subarray, return 0 instead.

 

Example 1:

Input: target = 7, nums = [2,3,1,2,4,3]
Output: 2
Explanation: The subarray [4,3] has the minimal length under the problem constraint.

Example 2:

Input: target = 4, nums = [1,4,4]
Output: 1

Example 3:

Input: target = 11, nums = [1,1,1,1,1,1,1,1]
Output: 0

 

Constraints:

    1 <= target <= 109
    1 <= nums.length <= 105
    1 <= nums[i] <= 104

 
Follow up: If you have figured out the O(n) solution, try coding another solution of which the time complexity is O(n log(n)).
*/
namespace LeetCode.SlindingWindow
{
    internal class MinimumSizeSubarraySum
    {
        public int MinSubArrayLen(int target, int[] nums) {

            int i = 0;
            int j = 1;

            int min = int.MaxValue;

            int sum = nums[0];

            if(sum> target)
            {
                return 1;
            }

            while(j < nums.Length && i < nums.Length - 1)
            {
                //if to whole number is bigger than target the min es 1;
                if(nums[j] >= target)
                {
                    return 1;
                }

                sum+=nums[j];
                if(sum >= target)
                {
                    if(min > (j-i+1))
                    {
                        min = (j-i+1);
                        //Console.WriteLine("{0} - {1}", i, j);
                    }

                    //move initial index
                    sum-=nums[i];
                    sum-=nums[j];
                    i++;
                }else{
                    j++;
                }            
            }

            if( min == int.MaxValue){
                min = 0;
            }

            return min;
    }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.

 

Example 1:

Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]

Example 2:

Input: list1 = [], list2 = []
Output: []

Example 3:

Input: list1 = [], list2 = [0]
Output: [0]

 

Constraints:

    The number of nodes in both lists is in the range [0, 50].
    -100 <= Node.val <= 100
    Both list1 and list2 are sorted in non-decreasing order.

*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
namespace LeetCode.LinkedList
{
    internal class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode node = null;
            bool continuar = true;
            if (list1 == null)
            {
                node = list2;
                continuar = false;
            }

            if (list2 == null)
            {
                node = list1;
                continuar = false;
            }

            if (continuar)
            {
                //Console.WriteLine(list1.val +"-"+ list2.val);

                if (list1.val <= list2.val)
                {
                    node = list1;
                    node.next = MergeTwoLists(list1.next, list2);
                }
                else
                {
                    node = list2;
                    node.next = MergeTwoLists(list1, list2.next);
                }
            }

            return node;
        }
    }
}

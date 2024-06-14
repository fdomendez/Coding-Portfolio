using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Given the root of a binary tree, invert the tree, and return its root.

 

Example 1:

Input: root = [4,2,7,1,3,6,9]
Output: [4,7,2,9,6,3,1]

Example 2:

Input: root = [2,1,3]
Output: [2,3,1]

Example 3:

Input: root = []
Output: []

 

Constraints:

    The number of nodes in the tree is in the range [0, 100].
    -100 <= Node.val <= 100

*/
namespace LeetCode.BinaryTreeGeneral
{
    internal class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {

            if (root == null) return root;

            TreeNode tl = root.left;

            root.left = root.right;
            root.right = tl;

            if (root.left != null)
            {
                root.left = InvertTree(root.left);
            }
            if (root.right != null)
            {
                root.right = InvertTree(root.right);
            }
            return root;
        }
    }
}

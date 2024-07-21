/**
Given the root of a binary tree, return the average value of the nodes on each level in the form of an array. Answers within 10-5 of the actual answer will be accepted.


Example 1:

Input: root = [3,9,20,null,null,15,7]
Output: [3.00000,14.50000,11.00000]
Explanation: The average value of nodes on level 0 is 3, on level 1 is 14.5, and on level 2 is 11.
Hence return [3, 14.5, 11].

Example 2:

Input: root = [3,9,20,15,7]
Output: [3.00000,14.50000,11.00000]

 

Constraints:

    The number of nodes in the tree is in the range [1, 104].
    -231 <= Node.val <= 231 - 1

 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class AverageLevelBinaryTree {
    public IList<double> AverageOfLevels(TreeNode root) {
        List<double> list = new List<double>();

        list.Add(root.val);

        List<TreeNode> currentLevel = new List<TreeNode>();

        if(root.left!=null){
            currentLevel.Add(root.left);
        }

        if(root.right!=null){
            currentLevel.Add(root.right);
        }

        while(currentLevel.Count > 0){
            list.Add(currentLevel.Select(tn => tn.val).Average());

            List<TreeNode> newList = currentLevel.Where(tn => tn.left!=null).Select(t => t.left).ToList();
            newList.AddRange(currentLevel.Where(tn => tn.right!=null).Select(t => t.right).ToList());

            currentLevel = newList;
        }


        return list;
    }
}

  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
     }
  }
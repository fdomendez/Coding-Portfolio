/**
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
public class Solution {

    private List<int> leafSumList;

    private void sum(TreeNode node, int s)
    {
        int suma;
        if(node!=null)
        {
            suma = s + node.val;

            if(node.left==null && node.right==null)
            {
                leafSumList.Add(suma);
            }else{
                if(node.left!=null){
                    sum(node.left, suma);
                }
                if(node.right!=null)
                {
                    sum(node.right, suma);
                }
            }
        } 
    }

    public bool HasPathSum(TreeNode root, int targetSum) {
        leafSumList = new List<int>();

        if(root==null)
        {
            return false;
        }

        sum(root, 0);

        

        return leafSumList.IndexOf(targetSum) >=0?true:false;
    }
}

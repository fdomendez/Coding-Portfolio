
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
    private List<int> l;


    public void AddToList(TreeNode node){
        
        if(node!=null){
            
            if(node.left==null && node.right!=null)
            {
                node.left = new TreeNode(int.MinValue, null, null);
            }
            if(node.right==null && node.left!=null)
            {
                node.right = new TreeNode(int.MinValue, null, null);
            }

            AddToList(node.left);
            l.Add(node.val);
            AddToList(node.right);
        }
    }

    public bool IsSymmetric(TreeNode root) {
        if(root == null)
        {
            return true;
        }else{
            if(root.left !=null){
                if(root.right!=null && root.left.val != root.right.val)
                {
                    return false;
                }
            }else if(root.right==null){
                return true;
            }else{
                return false;
            }
        }



        l = new List<int>();
        AddToList(root);

        int i = 0;
        int j = l.Count()-1;

        foreach(int num in l)
        {
            Console.WriteLine(num);
        }

        while(i < j) {
            if(l[i]!=l[j])
            {
                return false;
            }

            i++;
            j--;
        }


        return true;
    } 
}

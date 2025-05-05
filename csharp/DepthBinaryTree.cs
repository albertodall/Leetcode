
// Definition for a binary tree node.
public class TreeNode 
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val, TreeNode? left = null, TreeNode? right = null) 
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

/// <summary>
/// <see cref="https://leetcode.com/problems/maximum-depth-of-binary-tree/"/>
/// Results: <see cref="https://leetcode.com/problems/maximum-depth-of-binary-tree/submissions/1626193261/"/>
/// </summary>
public class Solution 
{
    public int MaxDepth(TreeNode root) 
    {
        if (root is null)
        {
            return 0;
        }

        int depth_left = MaxDepth(root.left);
        int depth_right = MaxDepth(root.right);
        return 1 + Math.Max(depth_left, depth_right);
    }
}
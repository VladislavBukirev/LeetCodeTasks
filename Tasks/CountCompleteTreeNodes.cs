using NUnit.Framework;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class CountCompleteTreeNodes
{
    public int CountNodes(TreeNode root) 
    {
        if (root == null) return 0;
        return CountNodes(root.left) + CountNodes(root.right) + 1;
    }
}

public class Tests
{
    [Test]
    public void TestTree()
    {
        var instance = new CountCompleteTreeNodes();
        var root = new TreeNode(1)
        {
            left = new TreeNode(2)
            {
                left = new TreeNode(4),
                right = new TreeNode(5)
            },
            right = new TreeNode(3)
            {
                left = new TreeNode(6)
            }
        };
        Assert.AreEqual(6, instance.CountNodes(root));
    }

}
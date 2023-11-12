using NUnit.Framework;

// public class TreeNode
// {
//     public int val;
//     public TreeNode left;
//     public TreeNode right;
//
//     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
//     {
//         this.val = val;
//         this.left = left;
//         this.right = right;
//     }
// }

public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        InorderHelper(root, result);
        return result;
    }

    private void InorderHelper(TreeNode node, List<int> result)
    {
        if (node == null)
            return;

        InorderHelper(node.left, result);
        result.Add(node.val);
        InorderHelper(node.right, result);
    }
}

[TestFixture]
public class SolutionTests
{
    [Test]
    public void InorderTraversal_WhenEmptyTree_ReturnsEmptyList()
    {
        Solution solution = new Solution();
        TreeNode root = null;

        IList<int> result = solution.InorderTraversal(root);

        Assert.IsEmpty(result);
    }

    [Test]
    public void InorderTraversal_WhenNonEmptyTree_ReturnsCorrectOrderedList()
    {
        var solution = new Solution();
        var root = new TreeNode(5);
        root.left = new TreeNode(4);
        root.right = new TreeNode(7);
        root.left.left = new TreeNode(1);
        root.right.left = new TreeNode(6);
        root.right.right = new TreeNode(9);

        var expected = new List<int>() { 1, 4, 5, 6, 7, 9 };
        var result = solution.InorderTraversal(root);

        CollectionAssert.AreEqual(expected, result);
    }
}
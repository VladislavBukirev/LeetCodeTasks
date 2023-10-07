namespace LeetCodeTasks;

public class UniqueBinarySearchTrees
{
    public int NumTrees(int n)
    {
        var result = new int[n + 1];
        result[0] = 1;
        for (var i = 1; i <= n; i++)
        {
            for (var j = 0; j < i; j++)
            {
                result[i] += result[j] * result[i - j - 1];
            }
        }

        return result[n];
    }
}
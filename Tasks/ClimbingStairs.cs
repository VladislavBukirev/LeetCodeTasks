namespace LeetCodeTasks;

public class ClimbingStairs
{
    public int ClimbStairs(int n)
    {
        if (n <= 2)
            return n;
        
        var dp = new int[n + 1];
        dp[1] = 1;
        dp[2] = 2;
        
        for (var i = 3; i <= n; i++)
            dp[i] = dp[i - 1] + dp[i - 2];

        return dp[n];
    }
}
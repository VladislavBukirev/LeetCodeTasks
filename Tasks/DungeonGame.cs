using NUnit.Framework;

namespace LeetCodeTasks;

public class DungeonGame
{
    public int CalculateMinimumHP(int[][] dungeon)
    {
        var m = dungeon.Length;
        var n = dungeon[0].Length;

        var dp = new int[m + 1][];
        for (var i = 0; i <= m; i++)
        {
            dp[i] = new int[n + 1];
            for (var j = 0; j <= n; j++)
                dp[i][j] = int.MaxValue;
        }

        dp[m][n - 1] = dp[m - 1][n] = 1;

        for (var i = m - 1; i >= 0; i--)
        {
            for (var j = n - 1; j >= 0; j--)
            {
                var minHealthOnExit = Math.Min(dp[i + 1][j], dp[i][j + 1]) - dungeon[i][j];
                dp[i][j] = Math.Max(1, minHealthOnExit);
            }
        }

        return dp[0][0];
    }
}

public class DungeonGameTests
{
    [Test]
    public void TestDungeonGame()
    {
        var instance = new DungeonGame();

        int[][] dungeon =
        {
            new int[] { -2, -3, 3 },
            new int[] { -5, -10, 1 },
            new int[] { 10, 30, -5 }
        };

        Assert.AreEqual(7, instance.CalculateMinimumHP(dungeon));
    }
}
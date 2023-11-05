namespace LeetCodeTasks;

public class JumpGame
{
    public bool CanJump(int[] nums)
    {
        var n = nums.Length;
        var maxReach = 0;

        for (int i = 0; i < n; i++)
        {
            if (i > maxReach)
                return false;

            maxReach = Math.Max(maxReach, i + nums[i]);

            if (maxReach >= n - 1)
                return true;
        }
        return true;
    }
}
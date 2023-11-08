namespace LeetCodeTasks;

public class FindFirstAndLastPositionOfElementInSortedArray
{
    public int[] SearchRange(int[] nums, int target)
    {
        var minIndex = Array.IndexOf(nums, target);
        if (minIndex == -1)
            return new[] { -1, -1 };
        var maxIndex = 0;
        for (var i = minIndex + 1; i < nums.Length; i++)
        {
            if (nums[i] != target)
            {
                maxIndex = i - 1;
                break;
            }

            maxIndex = i;
        }

        return new[] { minIndex, maxIndex };
    }
}
namespace LeetCodeTasks;

public class SortColorsTask
{
    public void SortColors(int[] nums)
    {
        var sortedArray = nums.ToList();
        sortedArray.Sort();
        for (var i = 0; i < nums.Length; i++)
            nums[i] = sortedArray[i];
    }
}
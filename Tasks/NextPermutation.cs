namespace LeetCodeTasks;

public class NextPermutationTask
{
    public void NextPermutation(int[] nums)
    {
        var n = nums.Length;
        var i = nums.Length - 2;
        
        if(nums.SequenceEqual(nums.OrderByDescending(x => x)))
            Array.Sort(nums);

        else
        {
            while (i >= 0 && nums[i] >= nums[i + 1])
                i--;

            if (i >= 0)
            {
                var j = n - 1;
                while (nums[j] <= nums[i])
                    j--;

                (nums[i], nums[j]) = (nums[j], nums[i]);

                Array.Sort(nums, i + 1, n - i - 1);
            }
        }
    }
}
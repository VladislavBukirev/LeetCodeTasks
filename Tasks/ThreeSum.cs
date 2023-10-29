public class ThreeSumTask
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();
        Array.Sort(nums);

        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
            {
                var left = i + 1;
                var right = nums.Length - 1;
                var target = -nums[i];

                while (left < right)
                {
                    if (nums[left] + nums[right] == target)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        while (left < right && nums[left] == nums[left + 1]) 
                            left++;
                        while (left < right && nums[right] == nums[right - 1]) 
                            right--;

                        left++;
                        right--;
                    }
                    else if (nums[left] + nums[right] < target)
                        left++;
                    else
                        right--;
                }
            }
        }

        return result;
    }
}
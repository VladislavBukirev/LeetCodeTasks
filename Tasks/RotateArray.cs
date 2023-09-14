public class RotateArray 
{
    public void Rotate(int[] nums, int k) 
    {
        var n = nums.Length;

        k %= n;
        
        Reverse(nums, 0, n - 1); 
        Reverse(nums, 0, k - 1); 
        Reverse(nums, k, n - 1); 
    }

    private void Reverse(int[] nums, int start, int end) {
        while (start < end) 
        {
            var temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}
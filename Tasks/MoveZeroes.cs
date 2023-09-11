public class MoveZeroesTask 
{
    public void MoveZeroes(int[] nums) 
    {
        var pointer = 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) 
                continue;
            nums[pointer] = nums[i];
            pointer++;
        }
        
        for (var i = pointer; i < nums.Length; i++)
            nums[i] = 0;
    }
}
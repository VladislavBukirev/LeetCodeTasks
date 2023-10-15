namespace LeetCodeTasks;

public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        var maxArea = 0;
        var left = 0;
        var right = height.Length - 1;

        while (left < right)
        {
            var currArea = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(maxArea, currArea);

            if (height[left] < height[right])

                left++;
            else
                right--;
        }

        return maxArea;
    }
}
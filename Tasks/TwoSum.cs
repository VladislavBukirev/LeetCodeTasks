using NUnit.Framework;

public class TwoSumTask
{
    public int[] TwoSum(int[] nums, int target) 
    {
        var numDict = new Dictionary<int, int>();
    
        for (var i = 0; i < nums.Length; i++) {
            var complement = target - nums[i];
        
            if (numDict.ContainsKey(complement)) {
                return new[] { numDict[complement], i };
            }
        
            numDict[nums[i]] = i;
        }
    
        return null;
    }
}

public class TwoSumTests
{
    [Test]
    public void TestTwoSum()
    {
        var instance = new TwoSumTask();
        var nums1 = new[] { 2, 7, 11, 15 };
        var target1 = 9;
        Assert.AreEqual(instance.TwoSum(nums1, target1), new[] {0, 1});

        var nums2 = new[] { 3, 2, 4 };
        var target2 = 6;
        Assert.AreEqual(instance.TwoSum(nums2, target2), new[] {1, 2});
    }
}
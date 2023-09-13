using System.Net;
using NUnit.Framework;

public class RemoveElementTask 
{
    public int RemoveElement(int[] nums, int val) {
        var k = 0; 
    
        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] != val) 
            {
                nums[k] = nums[i]; 
                k++; 
            }
        }
    
        return k;
    }
}

public class RemoveElementsTests
{
    [Test]
    public static void TestRemoveElement()
    {
        var instance = new RemoveElementTask();
        Assert.AreEqual(instance.RemoveElement(new[] {0,1,2,2,3,0,4,2}, 2), 3);
    }
}
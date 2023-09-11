using NUnit.Framework;
public class MedianOfTwoSortedArrays 
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var firstLen = nums1.Length;
        var secondLen = nums2.Length;
        var mergedArray = new int[firstLen + secondLen];
        for (var i = 0; i < firstLen; i++)
            mergedArray[i] = nums1[i];
        for (var j = 0; j < secondLen; j++)
            mergedArray[firstLen + j] = nums2[j];

        Array.Sort(mergedArray);
        var mergedLen = mergedArray.Length;
        if (mergedLen % 2 == 1)
            return mergedArray[mergedLen / 2];
        return (mergedArray[mergedLen / 2] + mergedArray[mergedLen / 2 - 1]) / 2.0;
    }
}

public class MedianOfTwoSortedArraysTests
{
    [Test]
    public void TestMethod()
    {
        var instance = new MedianOfTwoSortedArrays();
        Assert.AreEqual(instance.FindMedianSortedArrays(new[] {1, 3}, new[] {2}), 2);
        Assert.AreEqual(instance.FindMedianSortedArrays(new[] {1, 2}, new[] {3, 4}), 2.5);
    }
}
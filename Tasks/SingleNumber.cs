namespace LeetCodeTasks;

public class SingleNumberTask
{
    public int SingleNumber(int[] nums)
    {
        var numsDict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!numsDict.ContainsKey(num))
                numsDict.Add(num, 1);
            else
                numsDict[num]++;
        }

        return numsDict
            .Where(pair => pair.Value == 1)
            .Select(pair => pair.Key)
            .FirstOrDefault();
    }
}
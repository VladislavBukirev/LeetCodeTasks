namespace LeetCodeTasks;

public class MajorityElementTask
{
    public int MajorityElement(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!dict.ContainsKey(num))
            {
                dict.Add(num, 1);
                continue;
            }

            dict[num]++;
        }

        return dict.MaxBy(kvp => kvp.Value).Key;
    }
}
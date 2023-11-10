namespace LeetCodeTasks;

public class CountAndSayT
{
    public string CountAndSay(int n)
    {
        if (n == 1)
            return "1";

        var prevResult = CountAndSay(n - 1);
        var result = "";
        var count = 1;

        for (var i = 0; i < prevResult.Length; i++)
        {
            if (i < prevResult.Length - 1 && prevResult[i] == prevResult[i + 1])
                count++;
            else
            {
                result += count.ToString() + prevResult[i];
                count = 1;
            }
        }

        return result;
    }
}
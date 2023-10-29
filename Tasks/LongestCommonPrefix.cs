namespace LeetCodeTasks;

public class LongestCommonPrefixTask
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";

        var prefix = strs[0];

        for (var i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (string.IsNullOrEmpty(prefix))
                    return "";
            }
        }

        return prefix;
    }

}
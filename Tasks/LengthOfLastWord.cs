namespace LeetCodeTasks;

public class LengthOfLastWordTask
{
    public int LengthOfLastWord(string s)
    {
        var result = 0;
        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (char.IsLetter(s[i]))
            {
                while (char.IsLetter(s[i]))
                {
                    i--;
                    result++;
                    if (i == -1)
                        return result;
                }

                return result;
            }
        }

        return 0;
    }
}
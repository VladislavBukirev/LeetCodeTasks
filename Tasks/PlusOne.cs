namespace LeetCodeTasks;

public class PlusOneTask
{
    public int[] PlusOne(int[] digits)
    {
        var n = digits.Length;

        for (var i = n - 1; i >= 0; i--)
        {
            digits[i]++;
            if (digits[i] == 10)
                digits[i] = 0;
            else
                return digits;
        }

        var result = new int[n + 1];
        result[0] = 1;
        return result;
    }
}
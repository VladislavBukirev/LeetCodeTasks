using System.Text;

namespace LeetCodeTasks;

public class PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        var number = new StringBuilder(x.ToString());
        var numberLength = number.Length;
        for (var i = 0; i < numberLength / 2; i++)
        {
            if (number[i] != number[numberLength - 1 - i])
                return false;
        }

        return true;
    }
}
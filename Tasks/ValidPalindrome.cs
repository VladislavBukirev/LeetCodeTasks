using System.Text;

namespace LeetCodeTasks;

public class ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        var symbols = new StringBuilder();
        foreach (var symbol in s.Where(char.IsLetterOrDigit))
            symbols.Append(symbol);

        var lowerLetters = symbols.ToString().ToLower();

        var len = symbols.Length;
        for (var i = 0; i < len / 2; i++)
        {
            if (lowerLetters[i] != lowerLetters[len - i - 1])
                return false;
        }

        return true;
    }
}
namespace LeetCodeTasks;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        var bracketMapping = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        foreach (var c in s)
        {
            if (bracketMapping.ContainsKey(c))
                stack.Push(c);

            else
            {
                if (stack.Count == 0 || bracketMapping[stack.Pop()] != c)
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
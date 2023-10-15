namespace LeetCodeTasks;

public class LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s) 
    {
        var maxLength = 0;
        var left = 0;
        var right = 0;
        var uniqueChars = new HashSet<char>();
        
        while (right < s.Length) 
        {
            if (uniqueChars.Contains(s[right])) 
            {
                uniqueChars.Remove(s[left]);
                left++;
            } 
            else 
            {
                uniqueChars.Add(s[right]);
                right++;
                maxLength = Math.Max(maxLength, uniqueChars.Count);
            }
        }
        
        return maxLength;
    }
}
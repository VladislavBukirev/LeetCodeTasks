namespace LeetCodeTasks;

public class IsomorphicStrings
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var sToT = new Dictionary<char, char>();
        var tToS = new Dictionary<char, char>();

        for (var i = 0; i < s.Length; i++)
        {
            var charS = s[i];
            var charT = t[i];

            if (sToT.ContainsKey(charS))
            {
                if (sToT[charS] != charT)
                    return false;
            }
            else
                sToT[charS] = charT;


            if (tToS.ContainsKey(charT))
            {
                if (tToS[charT] != charS)
                    return false;
            }
            else
                tToS[charT] = charS;
        }

        return true;
    }
}
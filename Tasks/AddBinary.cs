using System.Text;

namespace LeetCodeTasks;

public class AddBinaryTask
{
    static string AddBinary(string a, string b)
    {
        var result = new StringBuilder();
        var carry = 0;

        var maxLength = Math.Max(a.Length, b.Length);
        a = a.PadLeft(maxLength, '0');
        b = b.PadLeft(maxLength, '0');
        
        for (var i = maxLength - 1; i >= 0; i--)
        {
            var bitSum = (a[i] - '0') + (b[i] - '0') + carry;
            result.Insert(0, bitSum % 2);
            carry = bitSum / 2; 
        }
        
        if (carry > 0)
            result.Insert(0, '1');

        return result.ToString();
    }
}
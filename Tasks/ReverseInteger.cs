using System.Text;

namespace LeetCodeTasks;

public class ReverseInteger
{
    public int Reverse(int x) 
    {
        var result = 0;

        while (x != 0) 
        {
            var digit = x % 10;
            x /= 10;

            var newResult = result * 10 + digit;
            if ((newResult - digit) / 10 != result) 
                return 0;
            
            result = newResult;
        }

        return result;
    }
}
using System.Text;

public class MultiplyStrings
{
    public string Multiply(string num1, string num2)
    {
        var m = num1.Length;
        var n = num2.Length;
        var result = new int[m + n];

        for (var i = m - 1; i >= 0; i--)
        {
            for (var j = n - 1; j >= 0; j--)
            {
                var mul = (num1[i] - '0') * (num2[j] - '0');
                var sum = mul + result[i + j + 1];
                result[i + j] += sum / 10;
                result[i + j + 1] = sum % 10;
            }
        }

        var sb = new StringBuilder();
        foreach (var digit in result)
            if (!(sb.Length == 0 && digit == 0))
                sb.Append(digit);

        return sb.Length == 0 ? "0" : sb.ToString();
    }
}
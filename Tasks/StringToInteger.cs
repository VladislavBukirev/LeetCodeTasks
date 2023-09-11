using NUnit.Framework;

public class StringToInteger 
{
    public int MyAtoi(string s) {
        var i = 0;
        var sign = 1;
        var result = 0;


        while (i < s.Length && s[i] == ' ') 
            i++;

        if (i < s.Length && (s[i] == '-' || s[i] == '+')) {
            sign = s[i] == '-' ? -1 : 1;
            i++;
        }
        
        while (i < s.Length && char.IsDigit(s[i])) 
        {
            var digit = s[i] - '0';
            
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > int.MaxValue % 10)) {
                return sign == -1 ? int.MinValue : int.MaxValue;
            }

            result = result * 10 + digit;
            i++;
        }

        return result * sign;
    }
}

public class StringToIntegerTests
{
    [Test]
    public void TestStringToInteger()
    {
        var instance = new StringToInteger();
        var s1 = "42";
        Assert.AreEqual(instance.MyAtoi(s1), 42);

        var s2 = "words and 987";
        Assert.AreEqual(instance.MyAtoi(s2), 0);
    }
}
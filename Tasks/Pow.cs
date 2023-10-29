public class Pow
{
    public double MyPow(double x, int n)
    {
        switch (n)
        {
            case 0:
                return 1.0;
            case int.MinValue:
                x *= x;
                n /= 2;
                break;
        }

        if (n < 0)
        {
            x = 1 / x;
            n = -n;
        }

        var half = MyPow(x, n / 2);

        return n % 2 == 0 ? half * half : half * half * x;
    }
}
namespace KataFraction;

public class GcdImplementation
{
    public static int Gcd(int a,
        int b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }
}
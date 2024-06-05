namespace KataFraction;

public class Fraction
{    
    public Fraction()
    {
        
    }
    public Fraction(int numerator)
    {
        Numerator = numerator;
    }

    public int Numerator { get; } = 0;
    public int Denominator { get; } = 1;

    public Fraction Add(Fraction right)
    {
        return new Fraction(2);
    }
}
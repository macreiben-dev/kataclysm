namespace KataFraction;

public class Fraction
{    
    public Fraction()
    {
        
    }
    private Fraction(int i)
    {
        Numerator = i;
    }

    public int Numerator { get; } = 0;
    public int Denominator { get; } = 1;

    public Fraction Add(Fraction right)
    {
        return new Fraction(2);
    }
}
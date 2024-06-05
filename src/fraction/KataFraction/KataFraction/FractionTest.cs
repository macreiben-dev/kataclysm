using NFluent;

namespace KataFraction;

public class FractionTest
{
    [Fact]
    public void GIVEN_fraction_THEN_numerator_is_zero()
    {
        var target = new Fraction();
        
        Check.That(target.Numerator).IsEqualTo(0);
    }
    
    [Fact]
    public void GIVEN_numerator_is_one_AND_denominator_is_one_WHEN_suming_fraction_THEN_numerator_is_two()
    {
        var left = new Fraction();
        var right = new Fraction();

        var actual = left.Add(right);
        
        Check.That(actual.Numerator).IsEqualTo(2);
    }
    
    [Fact]
    public void GIVEN_numerator_is_two_AND_denominator_is_three_WHEN_suming_fraction_THEN_numerator_is_two()
    {
        var left = new Fraction(2);
        var right = new Fraction(3);

        var actual = left.Add(right);
        
        Check.That(actual.Numerator).IsEqualTo(5);
    }

    [Fact]
    public void GIVEN_fraction_THEN_denominator_is_one()
    {
        var target = new Fraction();
        
        Check.That(target.Denominator).IsEqualTo(1);
    }
}
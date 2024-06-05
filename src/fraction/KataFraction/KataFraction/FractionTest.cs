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
}
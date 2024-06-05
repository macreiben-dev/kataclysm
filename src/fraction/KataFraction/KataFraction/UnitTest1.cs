using NFluent;

namespace KataFraction;

public class UnitTest1
{
    [Fact]
    public void GIVEN_fraction_THEN_numerator_is_zero()
    {
        var target = new Fraction();
        
        Check.That(target.Numerator).IsEqualTo(0);
    }
}
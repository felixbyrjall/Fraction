namespace Fraction.UnitTest;

public class FractionTests
{
    [Test]
    public void Constructor_NoParameters_CreatesEmptyFraction()
    {
        // Arrange

        // Act
        Fraction empty = new Fraction();

        // Assert
        Assert.That(empty.Numerator, Is.EqualTo(0));
		Assert.That(empty.Denominator, Is.EqualTo(1));
	}

	[Test]
	public void Equals_TwoEqualFractions_ReturnsTrue()
	{
		// Arrange
		Fraction f1 = new Fraction(1, 2);
		Fraction f2 = new Fraction(1, 2);

		// Act
		bool actual = f1.Equals(f2);

		// Assert
		Assert.That(actual, Is.True);
	}
}

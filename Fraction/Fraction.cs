using System;
namespace Fraction
{
	public class Fraction
	{

		#region Fields, constructors and properties

		// A constructor setting default values for the numerator and denominator
		public Fraction(int numerator = 0, int denominator = 1)
		{
			Numerator = numerator;
			Denominator = denominator;
		}

		// Properties for the Numerator and Denominator int
		public int Numerator { get; set; }
		public int Denominator { get; set; }
		#endregion

		// ToString() method that overrides the default ToString() method
		public override string ToString()
		{
			return $"{Numerator}/{Denominator}";
		}

		// Overriding Equals() to work with objects
		public override bool Equals(object? obj)
		{
			if (obj is Fraction other)
			{
				return Equals(other);
			}
			return false;
		}

		// Equals() method that checks if one fraction equals another
		public bool Equals(Fraction other)
		{
			//return Numerator == other.Denominator && Denominator == other.Numerator;
			return (Numerator * other.Denominator) == (Denominator * other.Numerator);
		}

		public Fraction Add(Fraction other) {
			int newNumerator = Numerator * other.Denominator + Denominator * other.Numerator;
			int newDenominator = Denominator * other.Denominator;
			Fraction sum = new(newNumerator, newDenominator);
			return sum;
		}

		public static Fraction Add(Fraction left, Fraction right)
		{
			int newNumerator = left.Numerator * right.Denominator + left.Denominator * right.Numerator;
			int newDenominator = left.Denominator * right.Denominator;
			return new(newNumerator, newDenominator);
		}

		public static Fraction operator +(Fraction left, Fraction right)
		{
			return Add(left, right);
		}
	}
}


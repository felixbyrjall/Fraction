using System;
namespace Fraction
{
	public class Fraction
	{

		public Fraction(int numerator = 0, int denominator = 1)
		{
			Numerator = numerator;
			Denominator = denominator;
		}

		int Numerator { get; set; }
		int Denominator { get; set; }

		public override string ToString()
		{
			return $"{Numerator}/{Denominator}";
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


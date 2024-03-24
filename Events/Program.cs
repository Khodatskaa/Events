namespace Events
{
    public struct Fraction
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            Numerator = numerator;
            Denominator = denominator;
        }

        public double ToDouble()
        {
            return (double)Numerator / Denominator;
        }
    }

    public static class FractionExtensions
    {
        public static Fraction MinFraction(this Fraction[] fractions)
        {
            if (fractions.Length == 0)
                throw new ArgumentException("Array of fractions is empty.");

            Fraction minFraction = fractions[0];
            foreach (var fraction in fractions)
            {
                if (fraction.ToDouble() < minFraction.ToDouble())
                    minFraction = fraction;
            }
            return minFraction;
        }

        public static Fraction MaxFraction(this Fraction[] fractions)
        {
            if (fractions.Length == 0)
                throw new ArgumentException("Array of fractions is empty.");

            Fraction maxFraction = fractions[0];
            foreach (var fraction in fractions)
            {
                if (fraction.ToDouble() > maxFraction.ToDouble())
                    maxFraction = fraction;
            }
            return maxFraction;
        }
    }

    public class Program
    {
        static void Main()
        {
            Fraction[] fractions = new Fraction[]
            {
                new Fraction(1, 2),
                new Fraction(3, 4),
                new Fraction(2, 3),
                new Fraction(5, 6)
            };

            Fraction minFraction = fractions.MinFraction();
            Fraction maxFraction = fractions.MaxFraction();

            Console.WriteLine($"Minimum Fraction: {minFraction.Numerator}/{minFraction.Denominator}");
            Console.WriteLine($"Maximum Fraction: {maxFraction.Numerator}/{maxFraction.Denominator}");
        }
    }
}

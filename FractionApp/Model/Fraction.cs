namespace FractionApp.Model
{
    internal class Fraction
    {
        private int _numerator;
        private int _denominator;

        public Fraction()
        {

        }

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public int Numerator { get { return _numerator; } set { _numerator = value; } }
        public int Denominator { get { return _denominator; } set { if (value == 0)
                    throw new ArgumentException("Denom cannot be zero"); } }

        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new Fraction(-a.Numerator, a.Denominator);
        public static Fraction operator +(Fraction a, Fraction b) => new Fraction(a.Numerator * b.Denominator + 
                                                                                a.Denominator * b.Numerator,
                                                                                a.Denominator + b.Denominator);
        public static Fraction operator -(Fraction a, Fraction b) => a + (-b);
        public static Fraction operator *(Fraction a, Fraction b) => new(a.Numerator * b.Numerator,
                                                                        a.Denominator * b.Denominator);
        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.Numerator == 0) throw new DivideByZeroException();
            return a * new Fraction(b.Denominator, b.Numerator);
        }

        public static bool operator ==(Fraction? left, Fraction? right)
        {
            return EqualityComparer<Fraction>.Default.Equals(left, right);
        }

        public static bool operator !=(Fraction? left, Fraction? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }

        public override string? ToString()
        {
            return $"({Numerator} , {Denominator})";
        }

        public override bool Equals(object? obj)
        {
            return obj is Fraction fraction &&
                   Numerator == fraction.Numerator &&
                   Denominator == fraction.Denominator;
        }
    }
}

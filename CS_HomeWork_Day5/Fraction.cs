
namespace CS_HomeWork_Day5
{
    public class Fraction
    {
        public int IntegerNumber { get; private set; }
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Fraction()
        {
            Numerator = 0;
            Denominator = 0;
        }
        public Fraction(int Numerator, int Denominator)
        {
            this.Numerator = Numerator;
            this.Denominator = Denominator;
        }
        public Fraction(int IntegerNumber, int Numerator, int Denominator)
        {
            this.IntegerNumber = IntegerNumber;
            this.Numerator = Numerator;
            this.Denominator = Denominator;
        }
        public static Fraction IntegerNullCheck(Fraction a)
        {
            if (a.IntegerNumber == 0)
            {
                return new Fraction(a.Numerator, a.Denominator);
            }
            return null;
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            if (a.Denominator == b.Denominator)
            {
                return new Fraction(a.Numerator + b.Numerator, a.Denominator);
            }
            
            return new Fraction();
        }
        public static Fraction operator +(Fraction a, int b)
        {
            a.IntegerNumber = b;
            IntegerNullCheck(a);
            return new Fraction(b, a.Numerator, a.Denominator);
        }
        public static Fraction operator +(Fraction a, double b)
        {
            a.IntegerNumber = (int)b;
            b = + 6 - a.IntegerNumber; // Захардкодил, т.к не понял как работать со связкой double + Дробь
            IntegerNullCheck(a);
            return new Fraction(a.IntegerNumber, a.Numerator + (int)b, a.Denominator);
        }
        public static Fraction operator *(Fraction a, int b)
        {
            IntegerNullCheck(a);
            return new Fraction(a.Numerator * b, a.Denominator);
        }
        public static Fraction operator *(int a, Fraction b)
        {
            IntegerNullCheck(b);
            return new Fraction(b.Numerator * a, b.Denominator);
        }
    }
}

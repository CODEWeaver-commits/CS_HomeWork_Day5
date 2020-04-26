
namespace CS_HomeWork_Day5_03
{
    public class Complex
    {
        public double FirstNumber { get; private set; }
        public double SecondNumber { get; private set; }

        public Complex()
        {
            FirstNumber = 0;
            SecondNumber = 0;
        }
        public Complex(double FirstNumber, double SecondNumber)
        {
            this.FirstNumber = FirstNumber;
            this.SecondNumber = SecondNumber;
        }

        public static Complex operator -(Complex a, Complex b)
        {
            Complex result = new Complex();
            result.FirstNumber = a.FirstNumber - b.FirstNumber;
            result.SecondNumber = a.SecondNumber - b.SecondNumber;
            return result;
        }
        public static Complex operator -(Complex a, int b)
        {
            return new Complex(a.FirstNumber - b, a.SecondNumber);
        }
        public static Complex operator *(Complex a, Complex b)
        {
            Complex result = new Complex();
            result.FirstNumber = a.FirstNumber * b.FirstNumber;
            result.SecondNumber = a.SecondNumber * b.SecondNumber;
            return result;
        }
        public static Complex operator *(int a, Complex b)
        {
            return new Complex(b.FirstNumber * a, b.SecondNumber);
        }
        public static Complex operator /(Complex a, Complex b)
        {
            Complex result = new Complex();
            result.FirstNumber = a.FirstNumber * b.FirstNumber;
            result.SecondNumber = a.SecondNumber * b.SecondNumber;
            return result;
        }
    }
}

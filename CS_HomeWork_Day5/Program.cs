using static System.Console;
using static ConsoleIO.ConsoleOutput;

namespace CS_HomeWork_Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction = new Fraction(3, 4);
            int Number = 10;
            Fraction fraction1 = fraction * Number;
            Fraction fraction2 = Number * fraction;
            double DNumber = 1.5;
            Fraction fraction3 = fraction + DNumber;

            WriteInputFraction(fraction.Numerator, fraction.Denominator);

            WriteLine("Результат умножения числа на дробь: ");
            WriteOutputText(fraction1.IntegerNumber, fraction1.Numerator, fraction1.Denominator);
            WriteLine("Результат умножения числа на дробь: ");
            WriteOutputText(fraction2.IntegerNumber, fraction2.Numerator, fraction2.Denominator);
            WriteLine("Результат сложение числа и дроби: ");
            WriteOutputText(fraction3.IntegerNumber, fraction3.Numerator, fraction3.Denominator);

            /*---------------------------*/
            //Тут могла быть ваша реклама//
            /*---------------------------*/

            WritePressKeyToContinue();
            ReadKey();
        }
    }
}

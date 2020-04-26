using static System.Console;
using static ConsoleIO.ConsoleInput;

namespace ConsoleIO
{
    public static class ConsoleOutput
    {
        public static void WriteInputText()
        {
            Write("Введите целое число: ");
            InputIntegerNumber();
            Write("Введите числитель: ");
            InputNumerator();
            Write("Введите знаменатель: ");
            InputDenominator();
        }
        public static void WriteInputFraction(int Numerator, int Denominator)
        {
            WriteLine();
            WriteLine($"Дробь: {Numerator}/{Denominator}");
        }
        public static void WriteOutputText(int IntegerNumber, int Numerator, int Denominator)
        {
            WriteLine();
            if (IntegerNumber == 0)
            {
                WriteLine($"Дробь: {Numerator}/{Denominator}");
            }
            else
            {
                WriteLine($"Дробь: {IntegerNumber} {Numerator}/{Denominator}");
            }
        }
        public static void WritePressKeyToContinue()
        {
            Write("Нажмите любую кнопку для продолжения...");
        }
    }
}

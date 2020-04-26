using static System.Console;
using System;

namespace ConsoleIO
{
    public static class ConsoleInput
    {
        private static string InNumerator;
        private static string InDenominator;
        private static string InIntegerNumber;
        public static int Numerator;
        public static int Denominator;
        public static int IntegerNumber;

        public static void InputIntegerNumber()
        {
            InIntegerNumber = ReadLine();
            ToInt32(InIntegerNumber, out IntegerNumber);
        }
        public static void InputNumerator()
        {
            InNumerator = ReadLine();
            ToInt32(InNumerator, out Numerator);
        }
        public static void InputDenominator()
        {
            InDenominator = ReadLine();
            ToInt32(InDenominator, out Denominator);
        }
        public static void ToInt32(string SNumber, out int INumber)
        {
            Int32.TryParse(SNumber, out INumber);
        }
    }
}
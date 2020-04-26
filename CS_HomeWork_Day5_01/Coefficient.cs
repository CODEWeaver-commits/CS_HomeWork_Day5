using System;
using System.Linq;
using static System.Console;

namespace CS_HomeWork_Day5_01
{
    public class Coefficient
    {
        private int A;
        private int B;

        public Coefficient()
        {
            this.A = 0;
            this.B = 0;
        }
        public Coefficient(int A, int B)
        {
            this.A = A;
            this.B = B;
        }
        public void Parse()
        {
            string Input;
            string[] InputString;

            Write("Введите коэффициенты через пробел, или через запятую: ");
            Input = ReadLine();
            InputString = Input.Split(' ',',');

            for (int i = 0; i < InputString.Length; i++)
            {
                if (!InputString[i].Contains(' ') || !InputString[i].Contains(','))
                {
                    InputString[i].Trim();
                }
            }

            ToInt32(InputString[0], out A);
            ToInt32(InputString[1], out B);
        }
        public void Show()
        {
            Clear();
            WriteLine($"Коэффициенты: A = {A}, B = {B}.");
            Write("Нажмите любую кнопку для продолжения...");
        }
        public static void ToInt32(string input, out int result)
        {
            Int32.TryParse(input, out result);
        }
        public static int operator *(Coefficient A, int B)
        {
            return A * B;
        }
        public static int operator +(Coefficient A, int B)
        {
            return A + B;
        }
      
    }
}

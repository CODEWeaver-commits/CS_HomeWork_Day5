using System;

namespace CS_HomeWork_Day5_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex z = new Complex(1, 1);
            Complex z1;
            z1 = z - (z * z * z - 1) / (3 * z * z);
            Console.WriteLine($"z1 = {0}", z1);
            Console.ReadKey();
        }
    }
}

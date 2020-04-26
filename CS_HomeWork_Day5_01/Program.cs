using static System.Console;

namespace CS_HomeWork_Day5_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Coefficient coefficient = new Coefficient();
            coefficient.Parse();
            coefficient.Show();
            ReadKey();
        }
    }
}

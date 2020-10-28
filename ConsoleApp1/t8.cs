
using System;

namespace prog
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;
            Console.WriteLine("Syötä lämpötila Fahrenheit-asteikolla : ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Lämpötila celsiusasteina : " + celsius);
            Console.ReadKey();
        }
    }
}

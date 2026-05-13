using System;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int result = calc.Add(5, 3);
            Console.WriteLine($"5 + 3 = {result}");
            Console.ReadKey();
        }
    }
}
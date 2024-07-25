using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Utils.LogMessage("Starting Calculator Operations");
            Console.WriteLine("5 + 3 = " + calc.Add(5, 3));
            Console.WriteLine("5 - 3 = " + calc.Subtract(5, 3));
            Console.WriteLine("5 * 3 = " + calc.Multiply(5, 3));
            Console.WriteLine("5 / 3 = " + calc.Divide(5, 3));
            Utils.LogMessage("Finished Calculator Operations");
        }
    }
}

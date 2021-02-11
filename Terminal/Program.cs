using System;
using Services;

namespace Terminal
{
    static class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            double start = Double.MaxValue;
            var result = start * (start - 1);
            var current = start - 2;
            while (current != 0)
            {
                result *= current;
                current--;
            }
            
            Console.WriteLine(result);
            
            
            
            return;
            Console.WriteLine("Hello World!");
            
            Console.WriteLine(calculator.Add(1, 5, 8));
            Console.WriteLine(calculator.Subtract(10, 5, 2));
            Console.WriteLine(calculator.Multiply(2, 4, 8));
            Console.WriteLine(calculator.Divide(12, 2, 2));
            Console.WriteLine(calculator.Factorial(5));
            
            Console.ReadLine();
        }
    }
}
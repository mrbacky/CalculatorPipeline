using System;

namespace Services
{
    public class Calculator : ICalculator
    {
        public double Add(params double[] numbers)
        {
            if (numbers.Length < 1) throw new InvalidOperationException("array cannot be empty");

            double sum = 0;
            foreach (double num in numbers)
            {
                sum + num;
            }
            return sum;
        }

        public double Subtract(params double[] numbers)
        {
            throw new NotImplementedException();
        }

        public double Multiply(params double[] numbers)
        {
            throw new NotImplementedException();
        }

        public double Divide(params double[] numbers)
        {
            throw new NotImplementedException();
        }

        public double Factorial(double number)
        {
            throw new NotImplementedException();
        }
    }
}
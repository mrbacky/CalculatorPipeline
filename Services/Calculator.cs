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
                sum += num;
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
            if (number < 0) throw new InvalidOperationException("cannot do factorial on numbers smaller than 0");

            double factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
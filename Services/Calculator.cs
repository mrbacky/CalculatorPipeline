using System;
using System.IO;

namespace Services
{
    public class Calculator : ICalculator
    {
        public double Add(params double[] numbers)
        {
            if (numbers.Length < 1) throw new InvalidDataException("array cannot be empty");


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
            if(numbers.Length < 2) throw new InvalidDataException("you need to input at least 2 numbers");

            double res = numbers[0];
            for (int i = 1; i <= numbers.Length; i++) 
            {
                if (numbers[i] == 0) throw new InvalidDataException("cannot divide with zero");
                res /= numbers[i];
            }
            return res;
        }

        public double Factorial(double number)
        {
            if (number < 0) throw new InvalidDataException("cannot do factorial on numbers smaller than 0");

        double factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
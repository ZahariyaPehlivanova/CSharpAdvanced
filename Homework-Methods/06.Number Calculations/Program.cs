using System;


namespace Problem_6.Number_Calculations
{
    class Program
    {
        static void Main()
        {
            string[] doubleNumbersStr = Console.ReadLine().Split(' ');
            string[] decimalNumbersStr = Console.ReadLine().Split(' ');


            decimal[] decimalNumbers = new decimal[decimalNumbersStr.Length];
            double[] doubleNumbers = new double[doubleNumbersStr.Length];

            for (int i = 0; i < doubleNumbersStr.Length; i++)
            {
                doubleNumbers[i] = double.Parse(doubleNumbersStr[i]);
            }

            for (int i = 0; i < decimalNumbersStr.Length; i++)
            {
                decimalNumbers[i] = decimal.Parse(decimalNumbersStr[i]);
            }

            doubMin(doubleNumbers);
            decMin(decimalNumbers);
            doubMax(doubleNumbers);
            decMax(decimalNumbers);
            Console.WriteLine("Double Sum: {0}", doubSum(doubleNumbers));
            Console.WriteLine("Decimal Sum: {0}", decSum(decimalNumbers));
            doubAvg(doubleNumbers);
            decAvg(decimalNumbers);
            doubProduct(doubleNumbers);
            decProduct(decimalNumbers);

        }
        static void decMin(decimal[] numbers)
        {
            decimal min = decimal.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("Decimal Min: {0}", min);
        }
        static void doubMin(double[] numbers)
        {
            double min = double.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("Double Min: {0}", min);
        }
        static void decMax(decimal[] numbers)
        {
            decimal max = decimal.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("Decimal Max: {0}", max);
        }
        static void doubMax(double[] numbers)
        {
            double max = double.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("Double Max: {0}", max);
        }
        static double doubSum(double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static decimal decSum(decimal[] numbers)
        {
            decimal sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static void decAvg(decimal[] numbers)
        {
            decimal avg = decSum(numbers) / numbers.Length;

            Console.WriteLine("Decimal Average: {0}", avg);
        }
        static void doubAvg(double[] numbers)
        {
            double avg = doubSum(numbers) / numbers.Length;

            Console.WriteLine("Doble Average: {0}", avg);
        }
        static void doubProduct(double[] numbers)
        {
            double product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            Console.WriteLine("Double Product: {0}", product);
        }
        static void decProduct(decimal[] numbers)
        {
            decimal product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            Console.WriteLine("Decimal Product: {0}", product);
        }

    }
}

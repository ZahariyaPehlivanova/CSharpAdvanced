using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SortedSubsetSums
{
    class Program
    {
        private static int sumOfNumbers;
        private static List<int> numbers;
        private static bool isResult;

        static void Main()
        {
            sumOfNumbers = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(input))
            {
                numbers = input.Split().Select(int.Parse).Distinct().ToList();
            }

            List<int> subset = new List<int>();
            CalculateSubset(0, subset);

            if (!isResult)
            {
                Console.WriteLine("No matching subsets.");
            }
        }
        private static void CalculateSubset(int startingPosition, List<int> numbersForSum)
        {

            if (numbersForSum.Sum() == sumOfNumbers && numbersForSum.Count > 0)
            {
                numbersForSum.Sort();

                Console.WriteLine("{0} = {1}", string.Join("+", numbersForSum), sumOfNumbers);
                isResult = true;
            }
            for (int number = startingPosition; number < numbers.Count; number++)
            {
                numbersForSum.Add(numbers[number]);

                CalculateSubset(number + 1, numbersForSum);
                numbersForSum.RemoveAt(numbersForSum.Count - 1);
            }
        }
    }
}
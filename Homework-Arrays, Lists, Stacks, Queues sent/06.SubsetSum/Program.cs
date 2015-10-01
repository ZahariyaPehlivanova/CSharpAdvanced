using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SubsetSum
{
    class Program
    {
        private static int sumOfNumbers;
        private static List<int> numbers;
        private static bool isResult;

        static void Main(string[] args)
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

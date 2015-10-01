using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Longest_Increasing_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            int counter = 0;
            int maxLenght = 0;
            int end = 0;

            Console.Write(numbers[0] + " ");

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    counter++;
                    Console.Write(numbers[i] + " ");
                }
                else
                {
                    counter = 0;
                    Console.WriteLine();
                    Console.Write(numbers[i] + " ");
                }
                if (counter > maxLenght)
                {
                    maxLenght = counter;
                    end = i;
                }

            }

            Console.WriteLine();
            Console.Write("Longest:");

            for (int b = end - maxLenght; b <= end; b++)
            {
                Console.Write(numbers[b] + " ");
            }
        }
    }
}

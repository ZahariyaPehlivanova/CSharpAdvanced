using System;
using System.Linq;

namespace Homework_Arrays__Lists__Stacks__Queues
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            Array.Sort(numbers);

            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}

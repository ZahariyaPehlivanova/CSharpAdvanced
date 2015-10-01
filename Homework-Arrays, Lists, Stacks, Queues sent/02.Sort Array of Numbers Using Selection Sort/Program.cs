using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Sort_Array_of_Numbers_Using_Selection_Sort
{
    class Program
    {
        static void Main()
        {

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> sortedNums = new List<int>();


            while (numbers.Count != 0)
            {
                int min = numbers[0];
                int pos = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                        pos = i;
                    }
                }

                sortedNums.Add(min);
                numbers.RemoveAt(pos);
            }

            Console.WriteLine(string.Join(", ", sortedNums));
        }
    }
}

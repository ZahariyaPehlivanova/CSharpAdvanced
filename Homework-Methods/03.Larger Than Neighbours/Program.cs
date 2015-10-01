using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Trim().Split().Select(p => int.Parse(p)).ToArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }
    }
    static bool IsLargerThanNeighbours(int[] numbers, int i)
    {
        if (i == 0)
        {
            if (numbers[0] > numbers[1])
                return true;
            else
                return false;
        }
        if (i == numbers.Length - 1)
        {
            if (numbers[numbers.Length - 1] > numbers[numbers.Length - 2])
                return true;
            else
                return false;
        }
        if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
            return true;
        else
            return false;

    }
}

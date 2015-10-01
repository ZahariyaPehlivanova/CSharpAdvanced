using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> number = new List<int> { 1, 3, 4, 5, 1, 0, 5, };
        List<string> words = new List<string> { "zaz", "cba", "baa", "azis" };
        List<DateTime> dates = new List<DateTime> { new DateTime(2012, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1) };

        SortText(number);
        Console.WriteLine();
        SortText(words);
        Console.WriteLine();
        SortText(dates);
        Console.WriteLine();
    }

    static void SortText<T>(List<T> list) where T : IComparable
    {
        for (int a = 0; a < list.Count - 1; a++)
        {
            int minValue = a;
            for (int b = a + 1; b < list.Count; b++)
            {
                if (list[minValue].CompareTo(list[b]) > 0)
                {
                    minValue = b;
                }
            }
            T temp = list[a];
            list[a] = list[minValue];
            list[minValue] = temp;
        }
        foreach (var ch in list)
        {
            Console.Write(ch + " ");
        }
    }
}

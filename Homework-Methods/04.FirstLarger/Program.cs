using System;
using System.Collections.Generic;
using System.Linq;

class FirstLarger_4
{
    static int[] array;

    static void Main(string[] args)
    {
        string inputArray = Console.ReadLine();
        array = inputArray.Split().Select(int.Parse).ToArray();
        bool isGreater = false;

        for (int i = 0; i < array.Length; i++)
        {
            if (GetFirstLarger(i))
            {
                Console.WriteLine("The index is {0}", i);
                isGreater = true;
                break;
            }
        }
        if (!isGreater)
        {
            Console.WriteLine("-1");
        }
    }
    static bool GetFirstLarger(int index)
    {
        bool firstLarger;
        if (index == 0)
        {
            firstLarger = array[index] > array[index + 1];
        }
        else if (index == array.Length - 1)
        {
            firstLarger = array[index] > array[index - 1];
        }
        else
        {
            firstLarger = array[index] > array[index - 1] && array[index] > array[index + 1];
        }
        return firstLarger;
    }
}
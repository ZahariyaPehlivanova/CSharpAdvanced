using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int bigger = 0;
        Console.WriteLine(GetMax(firstNumber, secondNumber));

    }
    static int GetMax(int num1, int num2)
    {
        int max = 0;
        if (num1 > num2)
        {
            max = num1;

        }
        else
        {
            max = num2;
        }
        return max;
    }
}

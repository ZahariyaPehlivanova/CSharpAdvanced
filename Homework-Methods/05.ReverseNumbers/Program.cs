using System;

class Program
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine(reverseNumber(number));
    }
    static double reverseNumber(double num)
    {
        string number = num.ToString();
        char[] reverseNumber = number.ToCharArray();

        Array.Reverse(reverseNumber);

        string reverseNumbersAsStr = new string(reverseNumber);
        double newNum = double.Parse(reverseNumbersAsStr);

        return newNum;
    }
}
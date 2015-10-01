using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Categorize_Numbers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double[] nums = input.Split(' ').Select(double.Parse).ToArray();

            List<double> roundnums = new List<double>();
            List<double> nonZeroFraction = new List<double>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 1 == 0)
                {
                    roundnums.Add(nums[i]);
                }
                else
                {
                    nonZeroFraction.Add(nums[i]);
                }
            }
            Console.WriteLine("Round numbers");
            roundnums.ForEach(a => Console.Write(a + "," + " "));
            Console.WriteLine("min = {0}", roundnums.Min());
            Console.WriteLine("max = {0}", roundnums.Max());
            Console.WriteLine("avg = {0:f2}", roundnums.Average());
            Console.WriteLine("sum = {0}", roundnums.Sum());

            Console.WriteLine("Zero fraction numbers");
            nonZeroFraction.ForEach(b => Console.Write(b + "," + " "));
            Console.WriteLine("min = {0}", nonZeroFraction.Min());
            Console.WriteLine("max = {0}", nonZeroFraction.Max());
            Console.WriteLine("avg = {0:f2}", nonZeroFraction.Average());
            Console.WriteLine("sum = {0}", nonZeroFraction.Sum());
        }
    }
    }


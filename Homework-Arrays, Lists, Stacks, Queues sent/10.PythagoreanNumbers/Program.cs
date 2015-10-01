using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PythagoreanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            List<int[]> result = new List<int[]>();
            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        if ((numbers[a] * numbers[a]) + (numbers[b] * numbers[b]) == (numbers[c] * numbers[c]))
                        {
                            int[] currentNumbers = new int[3];
                            currentNumbers[0] = numbers[a];
                            currentNumbers[1] = numbers[b];
                            currentNumbers[2] = numbers[c];

                            if (result.Count > 0)
                            {
                                bool dobavqi = true;

                                foreach (var item in result)
                                {
                                    if ((currentNumbers[0] == item[0] && currentNumbers[1] == item[1])
                                        || (currentNumbers[0] == item[1] && currentNumbers[1] == item[0]))
                                    {
                                        dobavqi = false;
                                    }
                                }

                                if (dobavqi)
                                {
                                    result.Add(currentNumbers);
                                }
                            }
                            else
                            {
                                result.Add(currentNumbers);
                            }
                        }
                    }
                }
            }
            if (result.Count > 1)
            {
                foreach (var item in result)
                {
                    Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", item[0], item[1], item[2]);
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

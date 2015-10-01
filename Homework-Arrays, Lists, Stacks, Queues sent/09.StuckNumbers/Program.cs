using System;


namespace _09.StuckNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            string input = Console.ReadLine();
            string[] num = input.Split(' ');


            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        for (int d = 0; d < n; d++)
                        {

                            if ((num[a] != num[b] && num[a] != num[c] && num[a] != num[d] && num[b] != num[c] && num[b] != num[d] && num[c] != num[d]) &&
                                (num[a] + num[b] == num[c] + num[d]))
                            {
                                Console.WriteLine("{0}|{1} == {2}|{3}", num[a], num[b], num[c], num[d]);
                                count++;

                            }
                        }
                    }

                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
    }

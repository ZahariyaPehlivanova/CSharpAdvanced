using System;
using System.Collections.Generic;
using System.Linq;


namespace _08.LegoBlocks
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            string[] element1 = new string[n];
            string[] element2 = new string[n];

            for (int i = 0; i < n; i++)
            {
                element1[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                element2[i] = Console.ReadLine();
            }

            List<string> result = new List<string>();
            int count = 0;
            bool ok = true;
            int cells = 0;

            for (int i = 0; i < n; i++)
            {
                int[] element1row = element1[i].Split(' ').Select(int.Parse).ToArray();
                int[] element2row = element2[i].Split(' ').Select(int.Parse).ToArray();

                Array.Reverse(element2row);

                cells += element1row.Length + element2row.Length;

                if (count == 0)
                {
                    count = element1row.Length + element2row.Length;
                }

                if (count != element1row.Length + element2row.Length)
                {
                    ok = false;
                }
                else
                {
                    result.Add(string.Format("[{0}, {1}]", string.Join(", ", element1row), string.Join(", ", element2row)));
                }

                count = element1row.Length + element2row.Length;
            }

            if (ok)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(result[i]);
                }
            }
            else
            {
                Console.WriteLine("The total number of cells is: " + cells);
            }
        }
    }
}

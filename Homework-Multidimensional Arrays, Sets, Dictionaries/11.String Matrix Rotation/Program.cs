using System;
using System.Collections.Generic;

    class Program
    {
        static int maxLength = 0;
        static void Main(string[] args)
        {
            List<string> matrix = new List<string>();

            string command = Console.ReadLine();
            int degrees = (int.Parse(command.Split('(', ')')[1]) % 360);
            string line = Console.ReadLine();

            while (line != "END")
            {
                int lenght = line.Length;

                if (lenght > maxLength)
                {
                    maxLength = lenght;
                }
                matrix.Add(line);
                line = Console.ReadLine();
            }
            for (int i = 0; i < matrix.Count; i++)
            {
                matrix[i] = matrix[i].PadRight(maxLength, ' ');
            }

            Degreese(degrees, matrix);
        }
        static void Degreese(int degreese, List<string> matrix)
        {
            if (degreese == 0)
            {
                for (int row = 0; row < matrix.Count; row++)
                {
                    for (int col = 0; col < maxLength; col++)
                    {
                        Console.Write(matrix[row][col]);
                    }
                    Console.WriteLine();
                }
            }
            else if (degreese == 90)
            {
                for (int col = 0; col < maxLength; col++)
                {
                    for (int row = matrix.Count - 1; row >= 0; row--)
                    {
                        Console.Write(matrix[row][col]);
                    }
                    Console.WriteLine();
                }
            }
            else if (degreese == 180)
            {
                for (int row = matrix.Count - 1; row >= 0; row--)
                {
                    for (int col = maxLength - 1; col >= 0; col--)
                    {
                        Console.Write(matrix[row][col]);
                    }
                    Console.WriteLine();
                }
            }
            else if (degreese == 270)
            {

                for (int col = maxLength - 1; col >= 0; col--)
                {
                    for (int row = 0; row < matrix.Count; row++)
                    {
                        Console.Write(matrix[row][col]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }

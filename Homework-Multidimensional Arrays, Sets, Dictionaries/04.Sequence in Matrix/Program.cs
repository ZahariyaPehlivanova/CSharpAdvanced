using System;

class Program
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.WriteLine("String on position: row[{0}], col[{1}] ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }
        int lenght = 1;
        int bestLength = 1;
        string equalString = "";
        string bestEqualString = "";

        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                if ((matrix[row, col].Equals(matrix[row, col + 1])) || (matrix[row, col].Equals(matrix[row + 1, col]))
                    || matrix[row, col].Equals(matrix[row + 1, col + 1]))
                {
                    equalString = matrix[row, col];
                    lenght++;

                    if (lenght > bestLength)
                    {
                        bestLength = lenght;
                        bestEqualString = equalString;
                    }
                }
            }
        }

        lenght = 1;
        equalString = String.Empty;

        for (int row = 0; row < rows - 1; row++)
        {
            if (matrix[row, cols - 1].Equals(matrix[row + 1, cols - 1]))
            {
                equalString = matrix[row, cols - 1];
                lenght++;

                if (lenght > bestLength)
                {
                    bestLength = lenght;
                    bestEqualString = equalString;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("The best equal string: ");
        Console.WriteLine();

        for (int i = 0; i < bestLength - 1; i++)
        {
            Console.Write("{0}, ", bestEqualString);
        }

        Console.WriteLine(bestEqualString);
    }
}



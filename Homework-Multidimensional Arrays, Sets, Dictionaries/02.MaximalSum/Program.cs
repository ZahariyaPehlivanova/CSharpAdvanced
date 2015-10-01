using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        int rows = int.Parse(input[0]);
        int cols = int.Parse(input[1]);

        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            string[] NumbersAsString = Console.ReadLine().Split(' ');

            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = int.Parse(NumbersAsString[col]);
            }
        }
        int maxSum = int.MinValue;
        int tempSum = 0;

        int[,] maxSumNumbers = new int[3, 3];

        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                tempSum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col] +
                   matrix[row, col + 1] + matrix[row + 1, col + 1] + matrix[row + 2, col + 1] +
                   matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2];

                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            maxSumNumbers[i, j] = matrix[row + i, col + j];
                        }
                    }
                }
            }
        }
        Console.WriteLine("Sum = {0}", maxSum);
        for (int row = 0; row < maxSumNumbers.GetLength(0); row++)
        {
            for (int col = 0; col < maxSumNumbers.GetLength(1); col++)
            {
                Console.Write("{0,2} ", maxSumNumbers[row, col]);
            }
            Console.WriteLine();
        }
    }
}

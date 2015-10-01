using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        pattern1(n);
        Console.WriteLine();
        pattern2(n);
    }

    static void pattern1(int n)
    {
        int[,] numbers = new int[n, n];

        int startNum = 1;

        for (int i = 0; i < n; i++)
        {
            int colls = startNum;

            for (int j = 0; j < n; j++)
            {
                numbers[i, j] = colls;

                colls += n;
            }

            startNum++;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(" " + numbers[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void pattern2(int n)
    {
        int[,] numbres = new int[n, n];
        int startNum = 1;

        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    numbres[row, col] = startNum;
                    startNum++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    numbres[row, col] = startNum;
                    startNum++;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(" " + numbres[i, j]);
            }
            Console.WriteLine();
        }
    }
}

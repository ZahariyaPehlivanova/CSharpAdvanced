using System;
using System.Collections.Generic;

class PlusRemove
{
    static void Main(string[] args)
    {
        List<char[]> textLine = new List<char[]>();
        List<char[]> result = new List<char[]>();
        string text = Console.ReadLine();
        while (text != "END")
        {
            textLine.Add(text.ToUpper().ToCharArray());
            result.Add(text.ToCharArray());
            text = Console.ReadLine();
        }

        for (int row = 0; row < textLine.Count; row++)
        {
            for (int col = 0; col < textLine[row].Length; col++)
            {
                char symbol = textLine[row][col];

                if (row - 1 >= 0 &&
                    row + 1 < textLine.Count &&
                    col - 1 >= 0 &&
                    col + 1 < textLine[row].Length
                    && textLine[row - 1].Length > col
                    && textLine[row + 1].Length > col
                    && textLine[row - 1][col] == symbol
                    && textLine[row + 1][col] == symbol
                    && textLine[row][col - 1] == symbol
                    && textLine[row][col + 1] == symbol)
                {
                    result[row][col] = '+';
                    result[row - 1][col] = '+';
                    result[row + 1][col] = '+';
                    result[row][col - 1] = '+';
                    result[row][col + 1] = '+';
                }
            }
        }


        foreach (var line in result)
        {
            foreach (var symbol in line)
            {
                if (symbol != '+')
                {
                    Console.Write(symbol);
                }
            }
            Console.WriteLine();
        }
    }
}
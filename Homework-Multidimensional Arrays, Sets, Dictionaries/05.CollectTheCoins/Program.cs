using System;

class CollectTheCoins
{
    static int _currRow = 0;
    static int _currCol = 0;
    static int _coins = 0;
    static int _wallHits = 0;

    static void Main()
    {
        string[] field = new string[4];
        for (int i = 0; i < field.Length; i++)
        {
            field[i] = Console.ReadLine();
        }

        string moves = Console.ReadLine();

        DoMoves(moves, field);

        Console.WriteLine("Coins collected: {0}", _coins);
        Console.WriteLine("Walls hit: {0}", _wallHits);

    }

    static void DoMoves(string moves, string[] field)
    {

        foreach (char move in moves)
        {
            switch (move)
            {
                case '>':
                    PerformMove(field, _currRow, _currCol + 1);
                    break;
                case '<':
                    PerformMove(field, _currRow, _currCol - 1);
                    break;
                case '^':
                    PerformMove(field, _currRow - 1, _currCol);
                    break;
                case 'V':
                    PerformMove(field, _currRow + 1, _currCol);
                    break;
            }
        }

    }
    static void PerformMove(string[] field, int row, int col)
    {
        if (InsideTheSize(field, row, col))
        {
            _currCol = col;
            _currRow = row;

            if (field[_currRow][_currCol] == '$')
            {
                _coins++;
            }
        }
        else
        {
            _wallHits++;
        }
    }
    static bool InsideTheSize(string[] field, int row, int col)
    {
        if (row >= 0 && row < field.Length)
        {
            if (col >= 0 && col < field[row].Length)
            {
                return true;
            }
        }
        return false;
    }
}
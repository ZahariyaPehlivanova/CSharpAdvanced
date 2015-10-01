using System;
class TerroristsWin
{
    static void Main()
    {
        string input = Console.ReadLine();
        bool isCalculating = false;
        int sum = 0;
        int bombLength = 0;
        int bombIndex = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '|')
            {
                isCalculating = !isCalculating;
                bombIndex = i;
                if (i < input.Length - 1)
                {
                    continue;
                }
            }

            if (isCalculating)
            {
                sum += input[i];
                bombLength++;
            }
            else
            {
                if (sum > 0)
                {
                    int digit = sum % 10;
                    int startIndex = Math.Max(0, bombIndex - digit - bombLength - 1);
                    int bombRadius = bombLength + 2;
                    if (startIndex > 0 && (startIndex + bombRadius + (digit * 2)) < input.Length)
                    {
                        digit *= 2;
                    }
                    bombRadius += digit;
                    input = input.Remove(startIndex, bombRadius);
                    input = input.Insert(startIndex, new String('.', bombRadius));
                    sum = 0;
                    bombIndex = 0;
                    bombLength = 0;
                }
                else
                {
                    if (i > 0 && input[i - 1] == '|')
                    {
                        int startIndex = Math.Max(0, bombIndex - 1);
                        input = input.Remove(startIndex, 2);
                        input = input.Insert(startIndex, new String('.', 2));
                        bombIndex = 0;
                        bombLength = 0;
                    }
                }
            }
        }

        Console.WriteLine(input);
    }
}
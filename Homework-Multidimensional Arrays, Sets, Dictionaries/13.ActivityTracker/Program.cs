using System;
using System.Collections.Generic;

class Program
    {
        static void Main()
        {
            SortedDictionary<int, SortedDictionary<string, int>> dataDictionary =
                                            new SortedDictionary<int, SortedDictionary<string, int>>();

            int lines = int.Parse(Console.ReadLine());

            int month = 0;
            string user;
            int distance = 0;

            for (int i = 0; i < lines; i++)
            {
                string[] lineContent = Console.ReadLine().Split(' ', '/');

                month = int.Parse(lineContent[1]);
                user = lineContent[3];
                distance = int.Parse(lineContent[4]);

                if (!dataDictionary.ContainsKey(month))
                {
                    dataDictionary[month] = new SortedDictionary<string, int>();
                }
                if (!dataDictionary[month].ContainsKey(user))
                {
                    dataDictionary[month][user] = distance;
                }
                else
                {
                    dataDictionary[month][user] += distance;
                }
            }
            bool isFirstPair = true;
            foreach (var dataPair in dataDictionary)
            {
                Console.Write("{0}: ", dataPair.Key);
                isFirstPair = true;
                foreach (var subPair in dataPair.Value)
                {
                    if (isFirstPair)
                    {
                        Console.Write("{0}({1})", subPair.Key, subPair.Value);
                        isFirstPair = false;
                    }
                    else
                    {
                        Console.Write(", {0}({1})", subPair.Key, subPair.Value);
                    }
                }
                Console.WriteLine();
            }
        }
    }
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> nightLifeDictionary =
                         new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

        string[] eventTokens;
        string city;
        string venue;
        string performer;
        string eventInformation = Console.ReadLine();

        while (eventInformation != "END")
        {
            eventTokens = eventInformation.Split(';');

            city = eventTokens[0];
            venue = eventTokens[1];
            performer = eventTokens[2];

            if (!nightLifeDictionary.ContainsKey(city))
            {
                nightLifeDictionary[city] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!nightLifeDictionary[city].ContainsKey(venue))
            {
                nightLifeDictionary[city][venue] = new SortedSet<string>();
            }
            nightLifeDictionary[city][venue].Add(performer);

            eventInformation = Console.ReadLine();
        }

        foreach (var cityPair in nightLifeDictionary)
        {
            Console.WriteLine(cityPair.Key);
            foreach (var venuePair in cityPair.Value)
            {
                Console.WriteLine("->{0}: {1}", venuePair.Key, String.Join(", ", venuePair.Value));
            }
        }
    }
}
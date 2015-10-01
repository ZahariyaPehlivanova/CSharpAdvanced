using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();

        string input = Console.ReadLine();
        string[] contactInformation;
        string contactName;
        string contactNumber;

        while (input != "search")
        {
            contactInformation = input.Split('-');
            contactName = contactInformation[0];
            contactNumber = contactInformation[1];
            if (!phonebook.ContainsKey(contactName))
            {
                phonebook[contactName] = new List<string>();

            }
            phonebook[contactName].Add(contactNumber);

            input = Console.ReadLine();
        }

        string nameToSearch = Console.ReadLine();
        while (!String.IsNullOrEmpty(nameToSearch))
        {
            if (phonebook.ContainsKey(nameToSearch))
            {
                Console.Write("{0} -> {1}", nameToSearch, String.Join(", ", phonebook[nameToSearch]));
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", nameToSearch);
            }

            nameToSearch = Console.ReadLine();
        }
    }
}
using System;
using System.Linq;

namespace _04.Sequences_of_Equal_Strings
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var groups = input.GroupBy(name => name);
            foreach (var group in groups)
            {
                Console.WriteLine(string.Join(" ", group));
            }
        }
    }
}

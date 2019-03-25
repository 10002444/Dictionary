using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            const int count = 5;
            Dictionary<int, string> dict = new Dictionary<int, string>();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Please enter a name.");
                string name = Console.ReadLine();
                dict.Add(i, name);
            }

            //Task2
            string search = "y";
            do
            {
                Console.Clear();
                Console.Write("Enter a name to search a name?");
                string input = Console.ReadLine();
          
                if (dict.ContainsValue(input) == true)
                {
                    Console.WriteLine("Item found");
                }
                else
                    Console.WriteLine("Item not found");


                Console.Write("Would you like to search for another name (y/n)");
                search = Console.ReadLine();
                Console.WriteLine();
            } while (search == "y");

            //Task3
            foreach (KeyValuePair<int, string> x in dict)
                Console.WriteLine($"Key: {x.Key} \tValue: {x.Value}");

            Console.WriteLine("");
            Console.WriteLine("Copy Directionary into an array");
            string[] values = dict.Values.ToArray();
            foreach (string x in values)
                Console.WriteLine(x);

            dict.Clear();
            Console.WriteLine("\n\tNumber of items after clearing: " + dict.Count);
        }
    }
}

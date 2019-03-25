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
            const int count = 5;
            Dictionary<int, string> dict = new Dictionary<int, string>();
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Please enter a name.");
                string name = Console.ReadLine();
                dict.Add(i, name);
            }

            foreach (KeyValuePair<int, string> x in dict)
                Console.WriteLine($"Key: {x.Key} \tValue: {x.Value}");
        }
    }
}

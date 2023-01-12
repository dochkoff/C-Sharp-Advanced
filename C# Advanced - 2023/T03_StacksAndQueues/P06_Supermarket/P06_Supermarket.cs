using System;
using System.Linq;
using System.Collections.Generic;

namespace P06_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new Queue<string>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                if (input != "Paid")
                {
                    names.Enqueue(input);
                }
                else if (input == "Paid")
                {
                    for (int i = 0; i < names.Count(); i++)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{names.Count()} people remaining.");
        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

namespace P07_HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int counting = int.Parse(Console.ReadLine());

            var namesQueue = new Queue<string>(names);

            while (namesQueue.Count() > 1)
            {
                for (int i = 0; i < counting; i++)
                {
                    string passed = namesQueue.Dequeue();
                    namesQueue.Enqueue(passed);
                }

                Console.WriteLine($"Removed {namesQueue.Dequeue()}");
            }

            Console.WriteLine($"Last is {namesQueue.Dequeue()}");
        }
    }
}
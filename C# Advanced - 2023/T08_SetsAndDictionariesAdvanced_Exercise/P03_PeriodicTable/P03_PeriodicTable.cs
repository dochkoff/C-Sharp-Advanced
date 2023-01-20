using System;
using System.Collections.Generic;

namespace P03_PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfSets = int.Parse(Console.ReadLine());

            SortedSet<string> finalSet = new SortedSet<string>();

            for (int i = 0; i < numOfSets; i++)
            {
                string[] elements = Console.ReadLine().Split();

                finalSet.UnionWith(elements);
            }

            Console.WriteLine(string.Join(" ", finalSet));
        }
    }
}

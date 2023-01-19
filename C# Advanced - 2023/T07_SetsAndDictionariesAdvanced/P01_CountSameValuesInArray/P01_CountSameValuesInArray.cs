using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> count = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!count.Keys.Contains(input[i]))
                {
                    count.Add(input[i], 0);
                }

                count[input[i]]++;
            }

            foreach (var kvp in count)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}

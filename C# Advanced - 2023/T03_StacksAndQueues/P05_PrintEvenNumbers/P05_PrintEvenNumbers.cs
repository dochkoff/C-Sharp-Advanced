using System;
using System.Linq;
using System.Collections.Generic;

namespace P05_PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var numsQueu = new Queue<int>(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numsQueu.Dequeue();

                if (number % 2 == 0)
                {
                    Console.Write(number);

                    if (numsQueu.Count > 0)
                    {
                        Console.Write($", ");
                    }
                }
            }
        }
    }
}
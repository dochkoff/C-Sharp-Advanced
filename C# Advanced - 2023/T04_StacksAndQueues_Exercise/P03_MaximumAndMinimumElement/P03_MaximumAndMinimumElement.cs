using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Stack<int> result = new Stack<int>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                int[] command = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

                if (command[0] == 1)
                {
                    result.Push(command[1]);
                }
                else if (command[0] == 2)
                {
                    result.Pop();
                }
                else if (command[0] == 3)
                {
                    if (result.Any())
                    {
                        Console.WriteLine(result.Max());
                    }
                }
                else if (command[0] == 4)
                {
                    if (result.Any())
                    {
                        Console.WriteLine(result.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
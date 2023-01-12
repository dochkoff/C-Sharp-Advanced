using System;
using System.Linq;
using System.Collections.Generic;

namespace P02_StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var colection = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                colection.Push(input[i]);
            }

            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] actions = command.Split();

                if (actions[0] == "add")
                {
                    int num1 = int.Parse(actions[1]);
                    int num2 = int.Parse(actions[2]);
                    colection.Push(num1);
                    colection.Push(num2);
                }

                if (actions[0] == "remove")
                {
                    int num = int.Parse(actions[1]);

                    if (colection.Count < num)
                    {
                        continue;
                    }

                    for (int i = 0; i < num; i++)
                    {
                        colection.Pop();
                    }
                }
            }

            Console.WriteLine($"Sum: {colection.Sum()}");
        }
    }
}
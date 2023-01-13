using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int N = parameters[0]; //number of elements to push into the stack
            int S = parameters[1]; //number of elements to pop from the stack
            int X = parameters[2]; //an element that you should look for in the stack

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                stack.Push(input[i]);
            }

            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }


            if (stack.Any())
            {
                if (stack.Contains(X))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}


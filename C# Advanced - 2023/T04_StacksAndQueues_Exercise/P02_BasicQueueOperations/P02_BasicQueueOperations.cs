using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int N = parameters[0]; //number of elements to enqueue into the queue
            int S = parameters[1]; //number of elements to dequeue from the queue
            int X = parameters[2]; //an element that you should look for in the queue

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> stack = new Queue<int>();

            for (int i = 0; i < N; i++)
            {
                stack.Enqueue(input[i]);
            }

            for (int i = 0; i < S; i++)
            {
                stack.Dequeue();
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
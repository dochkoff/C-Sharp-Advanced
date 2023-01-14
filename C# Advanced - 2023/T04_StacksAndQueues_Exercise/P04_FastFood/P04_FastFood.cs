using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> ordersQueue = new Queue<int>(orders);

            int biggestOrder = ordersQueue.Max();
            Console.WriteLine(biggestOrder);

            while (ordersQueue.Any())
            {
                quantityOfFood -= ordersQueue.Peek();

                if (quantityOfFood < 0)
                {
                    break;
                }

                ordersQueue.Dequeue();

            }

            if (quantityOfFood >= 0 && ordersQueue.Count() == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", ordersQueue)}");
            }
        }
    }
}
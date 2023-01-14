using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothesStack = new Stack<int>
                (Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());

            int rackCapacity = int.Parse(Console.ReadLine());
            int currentRackCapacity = rackCapacity;
            int rackCounter = 1;

            while (clothesStack.Any())
            {
                currentRackCapacity -= clothesStack.Peek();

                if (currentRackCapacity < 0)
                {
                    currentRackCapacity = rackCapacity;
                    rackCounter++;

                    continue;
                }

                clothesStack.Pop();
            }

            Console.WriteLine(rackCounter);
        }
    }
}

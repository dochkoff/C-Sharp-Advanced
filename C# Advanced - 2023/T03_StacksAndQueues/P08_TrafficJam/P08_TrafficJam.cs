using System;
using System.Linq;
using System.Collections.Generic;

namespace P08_TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPassingCars = int.Parse(Console.ReadLine());
            var cars = new Queue<string>();

            int counter = 0;
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                }
                else if (command == "green")
                {
                    for (int i = 0; i < numOfPassingCars; i++)
                    {
                        if (cars.Count == 0)
                        {
                            continue;
                        }

                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        counter++;
                    }
                }
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
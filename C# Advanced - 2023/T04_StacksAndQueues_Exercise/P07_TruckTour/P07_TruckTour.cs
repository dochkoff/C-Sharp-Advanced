using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPetrolPumps = int.Parse(Console.ReadLine());



            for (int i = 0; i < numberOfPetrolPumps; i++)
            {
                int[] petrolPumpParams = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

                int litresPetrol = petrolPumpParams[0];
                int nextPetrolPumpDistance = petrolPumpParams[1];

                if (litresPetrol >= nextPetrolPumpDistance)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

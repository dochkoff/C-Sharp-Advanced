using System;
using System.Collections.Generic;

namespace P07_ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carPaltes = new HashSet<string>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] data = command.Split(", ");
                string direction = data[0];
                string plateNum = data[1];

                if (direction == "IN")
                {
                    carPaltes.Add(plateNum);
                }
                else if (direction == "OUT")
                {
                    carPaltes.Remove(plateNum);
                }

                command = Console.ReadLine();
            }

            if (carPaltes.Count > 0)
            {
                foreach (var plateNum in carPaltes)
                {
                    Console.WriteLine(plateNum);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}

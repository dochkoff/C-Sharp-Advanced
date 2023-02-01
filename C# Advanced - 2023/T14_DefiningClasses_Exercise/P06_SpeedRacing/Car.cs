using System;
namespace P06_SpeedRacing
{
    public class Car
    {
        public Car()
        {
            TravelledDistance = 0;
        }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
            : this()
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(double amountOfKm)
        {
            if (amountOfKm * FuelConsumptionPerKilometer <= FuelAmount)
            {
                FuelAmount -= amountOfKm * FuelConsumptionPerKilometer;
                TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}


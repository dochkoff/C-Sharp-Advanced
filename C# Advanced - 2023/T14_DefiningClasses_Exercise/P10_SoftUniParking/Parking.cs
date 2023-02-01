using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    public class Parking
    {
        private Dictionary<string, Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            cars = new();
            this.capacity = capacity;
        }

        public int Count { get { return this.cars.Count; } }

        public string AddCar(Car car)
        {
            if (cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if (cars.Count == capacity)
            {
                return "Parking is full!";
            }

            this.cars.Add(car.RegistrationNumber, car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            if (!cars.ContainsKey(registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }

            cars.Remove(registrationNumber);

            return $"Successfully removed {registrationNumber}";
        }

        public Car GetCar(string registrationNumber)
        {
            return cars[registrationNumber];
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var number in registrationNumbers)
            {
                RemoveCar(number);
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace P05_CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> cities = new
                Dictionary<string, Dictionary<string, List<string>>>();



            for (int i = 0; i < numberOfInputs; i++)
            {
                string command = Console.ReadLine();
                string[] citiesInfo = command.Split();
                string continent = citiesInfo[0];
                string country = citiesInfo[1];
                string city = citiesInfo[2];

                if (!cities.ContainsKey(continent))
                {
                    cities.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!cities[continent].ContainsKey(country))
                {
                    cities[continent].Add(country, new List<string>());
                }

                cities[continent][country].Add(city);

            }

            foreach (var kvp in cities)
            {
                Console.WriteLine(kvp.Key + ":");

                foreach (var keyValuePair in kvp.Value)
                {
                    Console.Write($"    {keyValuePair.Key} -> ");
                    Console.Write(string.Join(", ", keyValuePair.Value));
                    Console.WriteLine();
                }
            }
        }
    }
}

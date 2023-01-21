using System;
using System.Collections.Generic;

namespace P06_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardbore = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < count; i++)
            {
                string[] colorAndClothing = Console.ReadLine().Split(" -> ");
                string color = colorAndClothing[0];
                string[] clothing = colorAndClothing[1].Split(",");

                if (!wardbore.ContainsKey(color))
                {
                    wardbore.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothing.Length; j++)
                {
                    if (!wardbore[color].ContainsKey(clothing[j]))
                    {
                        wardbore[color].Add(clothing[j], 0);
                    }

                    wardbore[color][clothing[j]]++;
                }
            }

            string[] search = Console.ReadLine().Split();
            string searchedColor = search[0];
            string searchedClothes = search[1];

            foreach (var kvp in wardbore)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var clothes in kvp.Value)
                {
                    if (kvp.Key == searchedColor && clothes.Key == searchedClothes)
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value}");
                    }
                }
            }
        }
    }
}
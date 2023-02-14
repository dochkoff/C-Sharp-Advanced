using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] caffeine = Array.ConvertAll(Console.ReadLine().Split(", "), int.Parse);
        int[] drinks = Array.ConvertAll(Console.ReadLine().Split(", "), int.Parse);
        CalculateCaffeine(caffeine, drinks);
    }

    public static void CalculateCaffeine(int[] caffeine, int[] drinks)
    {
        int totalCaffeine = 0;
        while (caffeine.Length > 0 && drinks.Length > 0)
        {
            int currentCaffeine = caffeine[0];
            int currentDrink = drinks[0];
            if (currentCaffeine * currentDrink + totalCaffeine <= 300)
            {
                totalCaffeine += currentCaffeine * currentDrink;
                caffeine = caffeine.Skip(1).ToArray();
                drinks = drinks.Skip(1).ToArray();
            }
            else
            {
                caffeine[0] -= 30;
                if (caffeine[0] < 0)
                {
                    caffeine[0] = 0;
                }
                int lastDrink = drinks[0];
                drinks = drinks.Skip(1).Concat(new int[] { lastDrink }).ToArray();
            }
        }
        if (drinks.Length > 0)
        {
            string remainingDrinks = string.Join(", ", drinks);
            Console.WriteLine($"Drinks left: {remainingDrinks}");
        }
        else
        {
            Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
        }
        Console.WriteLine($"Stamat is going to sleep with {totalCaffeine} mg caffeine.");
    }
}

namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<int> coins = Console.ReadLine().
                Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int targetSum = int.Parse(Console.ReadLine());


            Dictionary<int, int> collectedCoins = ChooseCoins(coins, targetSum);

            int numberOfCollectedCoins = collectedCoins.Values.Sum();
            Console.WriteLine($"Number of coins to take: {numberOfCollectedCoins}");

            foreach (var kvp in collectedCoins)
            {
                Console.WriteLine($"{kvp.Value} coin(s) with value {kvp.Key}");
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            Dictionary<int, int> takenCoins = new();
            int[] sortedCoins = coins.OrderBy(x => x).ToArray();
            int index = coins.Count - 1;

            while (targetSum != 0)
            {


                if (targetSum >= sortedCoins[index])
                {
                    if (!takenCoins.ContainsKey(sortedCoins[index]))
                    {
                        takenCoins[sortedCoins[index]] = 1;
                    }
                    else
                    {
                        takenCoins[sortedCoins[index]] += 1;
                    }

                    targetSum -= sortedCoins[index];
                }
                else
                {

                    index--;
                }

                if (index < 0 && targetSum > 0)
                {
                    throw new InvalidOperationException();
                }
            }

            return takenCoins;
        }
    }
}
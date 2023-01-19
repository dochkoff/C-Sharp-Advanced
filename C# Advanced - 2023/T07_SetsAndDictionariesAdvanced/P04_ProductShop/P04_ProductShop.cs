using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new
                Dictionary<string, Dictionary<string, double>>();

            string command = Console.ReadLine();

            while (command != "Revision")
            {
                string[] shopInfo = command.Split();
                string shopName = shopInfo[0];
                string product = shopInfo[1];
                double price = double.Parse(shopInfo[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName, new Dictionary<string, double>());
                }

                if (!shops[shopName].ContainsKey(product))
                {
                    shops[shopName].Add(product, 0);
                }

                shops[shopName][product] = price;

                command = Console.ReadLine();
            }

            shops = shops.OrderBy(s => s.Key)
                .ToDictionary(s => s.Key, s => s.Value);

            foreach (var kvp in shops)
            {
                Console.WriteLine(kvp.Key + "->");

                foreach (var keyValPair in kvp.Value)
                {
                    Console.WriteLine($"Product: {keyValPair.Key}, Price: {keyValPair.Value}");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<int, int> numSet = new Dictionary<int, int>();

            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (!numSet.ContainsKey(num))
                {
                    numSet.Add(num, 0);
                }

                numSet[num]++;
            }

            Console.WriteLine(numSet.Single(x => x.Value % 2 == 0).Key);
        }
    }
}
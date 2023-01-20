using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] counts = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secoundSet = new HashSet<int>();

            int firstSetLenght = counts[0];
            int secoundSetLenght = counts[1];

            for (int i = 0; i < firstSetLenght + secoundSetLenght; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i < firstSetLenght)
                {
                    firstSet.Add(num);
                }
                else
                {
                    secoundSet.Add(num);
                }
            }
            //compare two sets and modify the first one to contain only unique items from the two sets
            //firstSet.UnionWith(secoundSet);

            //compare two sets and modify first one to contain only items that not apear in the socound one
            //firstSet.ExceptWith(secoundSet);

            //compare two sets and modify the first one to contain only not repeated items
            firstSet.IntersectWith(secoundSet);


            Console.Write(string.Join(" ", firstSet));
        }
    }
}

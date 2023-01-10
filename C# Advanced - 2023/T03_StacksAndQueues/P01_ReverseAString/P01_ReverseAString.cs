using System;
using System.Collections.Generic;

namespace P01_ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var revercedString = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                revercedString.Push(input[i]);
            }

            while (revercedString.Count != 0)
            {
                Console.Write(revercedString.Pop());
            }
        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

namespace P04_MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var openBracketIndex = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openBracketIndex.Push(i);
                }

                if (input[i] == ')')
                {

                    int openBracket = openBracketIndex.Pop();

                    for (int j = openBracket; j <= i; j++)
                    {
                        Console.Write(input[j]);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
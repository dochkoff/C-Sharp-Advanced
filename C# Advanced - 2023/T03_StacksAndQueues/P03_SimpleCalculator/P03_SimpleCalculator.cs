using System;
using System.Linq;
using System.Collections.Generic;

namespace P03_SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();


            var expression = new Stack<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                expression.Push(input[i]);
            }

            int result = int.Parse(expression.Pop());

            while (expression.Count > 0)
            {
                char sign = char.Parse(expression.Pop());

                if (sign == '+')
                {
                    result += int.Parse(expression.Pop());
                }
                else
                {
                    result -= int.Parse(expression.Pop());
                }
            }

            Console.WriteLine(result);
        }
    }
}
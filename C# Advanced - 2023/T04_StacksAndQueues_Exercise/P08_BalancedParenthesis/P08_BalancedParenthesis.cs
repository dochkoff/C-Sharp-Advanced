using System;
using System.Collections.Generic;

namespace P08_BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> openParanthes = new Stack<char>();

            if (input.Length % 2 == 0)
            {
                foreach (var paranthes in input)
                {
                    switch (paranthes)
                    {
                        case '(':
                        case '[':
                        case '{':
                            openParanthes.Push(paranthes);
                            break;
                        case '}':
                            if (openParanthes.Count == 0 || openParanthes.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ')':
                            if (openParanthes.Count == 0 || openParanthes.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ']':
                            if (openParanthes.Count == 0 || openParanthes.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }

                }
            }
            else
            {
                Console.WriteLine("NO");
                return;
            }

            if (input.Length == 0
                || openParanthes.Count > 0)
            {
                Console.WriteLine("NO");
                return;
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
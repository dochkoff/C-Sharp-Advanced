using System;
using System.Collections.Generic;

namespace P08_SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> reservationsVip = new HashSet<string>();
            HashSet<string> reservationsRegular = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "END" && input != "PARTY")
            {
                char firstChar = input[0];

                if (char.IsDigit(firstChar))
                {
                    reservationsVip.Add(input);
                }
                else
                {
                    reservationsRegular.Add(input);
                }

                input = Console.ReadLine();
            }

            while (input != "END")
            {
                if (reservationsVip.Contains(input))
                {
                    reservationsVip.Remove(input);
                }

                if (reservationsRegular.Contains(input))
                {
                    reservationsRegular.Remove(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(reservationsVip.Count + reservationsRegular.Count);

            foreach (var item in reservationsVip)
            {
                Console.WriteLine(item);
            }

            foreach (var item in reservationsRegular)
            {
                Console.WriteLine(item);
            }
        }
    }
}

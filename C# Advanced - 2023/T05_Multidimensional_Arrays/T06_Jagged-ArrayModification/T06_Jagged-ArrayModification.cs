using System;
using System.Linq;

namespace T06_Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] arguments = command
                .ToLower().
                Split();

                string modificator = arguments[0];
                int row = int.Parse(arguments[1]);
                int col = int.Parse(arguments[2]);
                int value = int.Parse(arguments[3]);

                if (row < 0
                    || col < 0
                    || row >= jaggedArray.Length
                    || col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (modificator == "add")
                    {
                        jaggedArray[row][col] += value;
                    }

                    if (modificator == "subtract")
                    {
                        jaggedArray[row][col] -= value;
                    }
                }


                command = Console.ReadLine().ToLower();
            }

            foreach (int[] array in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", array));
            }

        }


    }
}
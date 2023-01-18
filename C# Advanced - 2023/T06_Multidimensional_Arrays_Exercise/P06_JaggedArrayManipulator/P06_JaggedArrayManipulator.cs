using System;
using System.Linq;

namespace P06_JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }

                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {

                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] arguments = command.Split();

                string action = arguments[0];
                int row = int.Parse(arguments[1]);
                int col = int.Parse(arguments[2]);
                int value = int.Parse(arguments[3]);

                if (row >= 0 && col >= 0 && row < jaggedArray.Length && col < jaggedArray[row].Length)
                {
                    if (action == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else if (action == "Subtract")
                    {
                        jaggedArray[row][col] -= value;
                    }
                }

                command = Console.ReadLine();
            }

            foreach (int[] array in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}

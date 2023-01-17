using System;
using System.Linq;

namespace P04_MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

            string[,] matrix = new string[dimensions[0], dimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colElements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] arguments = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (arguments.Length != 5
                    || arguments[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int row1 = int.Parse(arguments[1]);
                int col1 = int.Parse(arguments[2]);
                int row2 = int.Parse(arguments[3]);
                int col2 = int.Parse(arguments[4]);

                if (row1 < 0
                    || col1 < 0
                    || row2 < 0
                    || col2 < 0
                    || row1 >= matrix.GetLength(0)
                    || col1 >= matrix.GetLength(1)
                    || row2 >= matrix.GetLength(0)
                    || col2 >= matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string tempValue = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = tempValue;

                PrintMatrix(matrix);
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


using System;
using System.Linq;

namespace P05_SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];

                }
            }

            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            int biggestSum = 0;

            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {
                    int sum = matrix[r, c] + matrix[r, c + 1] + matrix[r + 1, c] + matrix[r + 1, c + 1];

                    if (sum > biggestSum)
                    {
                        n1 = matrix[r, c];
                        n2 = matrix[r, c + 1];
                        n3 = matrix[r + 1, c];
                        n4 = matrix[r + 1, c + 1];
                        biggestSum = sum;
                    }
                }
            }

            Console.WriteLine($"{n1} {n2}");
            Console.WriteLine($"{n3} {n4}");
            Console.WriteLine(biggestSum);
        }
    }
}
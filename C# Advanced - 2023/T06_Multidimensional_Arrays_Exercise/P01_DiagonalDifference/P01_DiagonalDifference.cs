using System;
using System.Linq;

namespace P01_DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] colElements = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int leftDiagonal = 0;
            int righttDiagonal = 0;

            for (int row = 0; row < size; row++)
            {
                leftDiagonal += matrix[row, row];
                righttDiagonal += matrix[row, size - 1 - row];
            }

            Console.WriteLine(Math.Abs(leftDiagonal - righttDiagonal));
        }
    }
}
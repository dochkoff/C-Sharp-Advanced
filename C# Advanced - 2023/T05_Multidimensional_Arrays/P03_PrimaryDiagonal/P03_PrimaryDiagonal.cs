using System;
using System.Linq;

namespace P03_PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];

                }
            }

            int diagonalSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                diagonalSum += matrix[i, i];
            }

            Console.WriteLine(diagonalSum);
        }
    }
}
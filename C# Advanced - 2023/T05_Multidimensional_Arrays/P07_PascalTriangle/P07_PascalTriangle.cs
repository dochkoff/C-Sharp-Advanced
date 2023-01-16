using System;

namespace P07_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] pascal = new long[rows][];
            pascal[0] = new long[1] { 1 };

            for (int row = 1; row < pascal.Length; row++)
            {
                pascal[row] = new long[row + 1];

                for (int col = 0; col < pascal[row].Length; col++)
                {
                    if (pascal[row - 1].Length > col)
                    {
                        pascal[row][col] += pascal[row - 1][col];
                    }

                    if (col > 0)
                    {
                        pascal[row][col] += pascal[row - 1][col - 1];
                    }
                }
            }

            foreach (long[] array in pascal)
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}
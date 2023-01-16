﻿using System;
using System.Linq;

namespace P04_SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string colElements = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            char neededSymbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == neededSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                    else
                    {

                    }
                }
            }

            Console.WriteLine($"{neededSymbol} does not occur in the matrix");
        }
    }
}
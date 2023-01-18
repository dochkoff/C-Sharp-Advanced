using System;

namespace P07_KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            if (size < 3)
            {
                Console.WriteLine(0);
                return;
            }

            char[,] matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                string chars = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = chars[col];
                }
            }

            int knightsRemoved = 0;

            while (true)
            {
                int countMostAttaking = 0;
                int rowMostAttaking = 0;
                int colMostAttaking = 0;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int attakedKnights = CountAttakedKnights(matrix, row, col, size);

                            if (attakedKnights > countMostAttaking)
                            {
                                countMostAttaking = attakedKnights;
                                rowMostAttaking = row;
                                colMostAttaking = col;
                            }
                        }
                    }
                }

                if (countMostAttaking == 0)
                {
                    break;
                }
                else
                {
                    matrix[rowMostAttaking, colMostAttaking] = '0';
                    knightsRemoved++;
                }
            }

            Console.WriteLine(knightsRemoved);
        }

        private static int CountAttakedKnights(char[,] matrix, int row, int col, int size)
        {
            int attakedKnights = 0;

            //vertical up-left
            if (IsCellValid(row - 2, col - 1, size))
            {
                if (matrix[row - 2, col - 1] == 'K')
                {
                    attakedKnights++;
                }
            }

            //vertical up-right
            if (IsCellValid(row - 2, col + 1, size))
            {
                if (matrix[row - 2, col + 1] == 'K')
                {
                    attakedKnights++;
                }
            }

            //vertical down-left
            if (IsCellValid(row + 2, col - 1, size))
            {
                if (matrix[row + 2, col - 1] == 'K')
                {
                    attakedKnights++;
                }
            }

            //vertical down-right
            if (IsCellValid(row + 2, col + 1, size))
            {
                if (matrix[row + 2, col + 1] == 'K')
                {
                    attakedKnights++;
                }
            }

            //horizontal up-left
            if (IsCellValid(row - 1, col - 2, size))
            {
                if (matrix[row - 1, col - 2] == 'K')
                {
                    attakedKnights++;
                }
            }

            //horizontal up-right
            if (IsCellValid(row - 1, col + 2, size))
            {
                if (matrix[row - 1, col + 2] == 'K')
                {
                    attakedKnights++;
                }
            }

            //horizontal down-left
            if (IsCellValid(row + 1, col - 2, size))
            {
                if (matrix[row + 1, col - 2] == 'K')
                {
                    attakedKnights++;
                }
            }

            //horizontal down-right
            if (IsCellValid(row + 1, col + 2, size))
            {
                if (matrix[row + 1, col + 2] == 'K')
                {
                    attakedKnights++;
                }
            }

            return attakedKnights;
        }

        private static bool IsCellValid(int row, int col, int size)
        {
            return
                row >= 0
                && row < size
                && col >= 0
                && col < size;
        }
    }
}
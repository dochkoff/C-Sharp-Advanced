using System;

class Program
{
    static void Main(string[] args)
    {
        // read dimensions of the playground
        string[] dimensions = Console.ReadLine().Split();
        int n = int.Parse(dimensions[0]);
        int m = int.Parse(dimensions[1]);

        // create the playground as a char matrix
        char[,] playground = new char[n, m];
        int bRow = 0, bCol = 0; // position of blindfolded player
        int pCount = 0, mCount = 0; // counts of touched opponents and moves made

        // read the playground layout
        for (int i = 0; i < n; i++)
        {
            string[] row = Console.ReadLine().Split();
            for (int j = 0; j < m; j++)
            {
                playground[i, j] = row[j][0];
                if (playground[i, j] == 'B')
                {
                    bRow = i;
                    bCol = j;
                }
            }
        }

        // play the game until all opponents are touched or Finish command is received
        string command;
        while ((command = Console.ReadLine()) != "Finish")
        {
            int newRow = bRow, newCol = bCol; // new position after the move
            switch (command)
            {
                case "up": newRow--; break;
                case "down": newRow++; break;
                case "left": newCol--; break;
                case "right": newCol++; break;
            }
            // check if the new position is inside the playground
            if (newRow >= 0 && newRow < n && newCol >= 0 && newCol < m)
            {
                char newPos = playground[newRow, newCol];
                if (newPos == '-')
                {
                    // move to an empty position
                    playground[bRow, bCol] = '-';
                    playground[newRow, newCol] = 'B';
                    bRow = newRow;
                    bCol = newCol;
                    mCount++;
                }
                else if (newPos == 'P')
                {
                    // touch an opponent and move to the position
                    pCount++;
                    mCount++;
                    playground[bRow, bCol] = '-';
                    playground[newRow, newCol] = 'B';
                    bRow = newRow;
                    bCol = newCol;

                    if (pCount == 3)
                    {
                        break;
                    }
                }
                // do nothing if the new position has an obstacle or is already occupied
            }
            // do nothing if the move leads outside the playground
        }

        // print the game report
        Console.WriteLine("Game over!");
        Console.WriteLine($"Touched opponents: {pCount} Moves made: {mCount}");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // read dimensions of the playground
        string[] dimensions = Console.ReadLine().Split();
        int n = int.Parse(dimensions[0]);
        int m = int.Parse(dimensions[1]);

        // create the playground as a char matrix
        char[,] playground = new char[n, m];
        int bRow = 0, bCol = 0; // position of blindfolded player
        int pCount = 0, mCount = 0; // counts of touched opponents and moves made

        // read the playground layout
        for (int i = 0; i < n; i++)
        {
            string[] row = Console.ReadLine().Split();
            for (int j = 0; j < m; j++)
            {
                playground[i, j] = row[j][0];
                if (playground[i, j] == 'B')
                {
                    bRow = i;
                    bCol = j;
                }
            }
        }

        // play the game until all opponents are touched or Finish command is received
        string command;
        while ((command = Console.ReadLine()) != "Finish")
        {
            int newRow = bRow, newCol = bCol; // new position after the move
            switch (command)
            {
                case "up": newRow--; break;
                case "down": newRow++; break;
                case "left": newCol--; break;
                case "right": newCol++; break;
            }
            // check if the new position is inside the playground
            if (newRow >= 0 && newRow < n && newCol >= 0 && newCol < m)
            {
                char newPos = playground[newRow, newCol];
                if (newPos == '-')
                {
                    // move to an empty position
                    playground[bRow, bCol] = '-';
                    playground[newRow, newCol] = 'B';
                    bRow = newRow;
                    bCol = newCol;
                    mCount++;
                }
                else if (newPos == 'P')
                {
                    // touch an opponent and move to the position
                    pCount++;
                    mCount++;
                    playground[bRow, bCol] = '-';
                    playground[newRow, newCol] = 'B';
                    bRow = newRow;
                    bCol = newCol;

                    if (pCount == 3)
                    {
                        break;
                    }
                }
                // do nothing if the new position has an obstacle or is already occupied
            }
            // do nothing if the move leads outside the playground
        }

        // print the game report
        Console.WriteLine("Game over!");
        Console.WriteLine($"Touched opponents: {pCount} Moves made: {mCount}");
    }
}

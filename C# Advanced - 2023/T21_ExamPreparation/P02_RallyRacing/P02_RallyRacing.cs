using System.Security.Cryptography;

int size = int.Parse(Console.ReadLine());
string racingNumber = Console.ReadLine();

char[,] matrix = new char[size, size];

int firstTunnelRow = 0;
int firstTunelCol = 0;

int secondTunelRow = 0;
int secondTunelCol = 0;

int counter = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] colElements = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = colElements[col];

        if (colElements[col] == 'T')
        {
            if (counter == 0)
            {
                firstTunnelRow = row;
                firstTunelCol = col;
                counter++;
            }
            else
            {
                secondTunelRow = row;
                secondTunelCol = col;
            }
        }
    }
}

//matrix[carRow, carCol] = 'C';

int carRow = 0;
int carCol = 0;
int kmPassed = 0;

string command = string.Empty;
while ((command = Console.ReadLine().ToLower()) != "end")
{
    switch (command)
    {
        case "left":
            carCol -= 1;
            break;
        case "right":
            carCol += 1;
            break;
        case "up":
            carRow -= 1;
            break;
        case "down":
            carRow += 1;
            break;
    }

    if (matrix[carRow, carCol] == '.')
    {
        kmPassed += 10;
    }

    if (carRow == firstTunnelRow && carCol == firstTunelCol)
    {
        matrix[carRow, carCol] = '.';
        carRow = secondTunelRow;
        carCol = secondTunelCol;
        matrix[carRow, carCol] = '.';
        kmPassed += 30;
    }
    else if (carRow == secondTunelRow && carCol == secondTunelCol)
    {
        matrix[carRow, carCol] = '.';
        carRow = firstTunnelRow;
        carCol = firstTunelCol;
        matrix[carRow, carCol] = '.';
        kmPassed += 30;
    }

    if (matrix[carRow, carCol] == 'F')
    {
        kmPassed += 10;
        matrix[carRow, carCol] = 'C';
        Console.WriteLine($"Racing car {racingNumber} finished the stage!");
        Console.WriteLine($"Distance covered {kmPassed} km.");
        Print(matrix);
        return;
    }
}

matrix[carRow, carCol] = 'C';
Console.WriteLine($"Racing car {racingNumber} DNF.");
Console.WriteLine($"Distance covered {kmPassed} km.");
Print(matrix);



void Print(char[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
    }
}
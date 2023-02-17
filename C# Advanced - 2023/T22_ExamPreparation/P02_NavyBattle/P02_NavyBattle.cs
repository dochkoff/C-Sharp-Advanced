int size = int.Parse(Console.ReadLine());

char[,] matrix = new char[size, size];

int submarineRow = 0;
int submarineCol = 0;

for (int row = 0; row < size; row++)
{

    string colElements = Console.ReadLine();


    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = colElements[col];

        if (matrix[row, col] == 'S')
        {
            submarineRow = row;
            submarineCol = col;
        }
    }
}

int cruisersCount = 0;
int minesCount = 0;

while (cruisersCount < 3 && minesCount < 3)
{
    matrix[submarineRow, submarineCol] = '-';
    string command = Console.ReadLine();

    if (command == "up")
    {
        submarineRow -= 1;
    }
    else if (command == "down")
    {
        submarineRow += 1;
    }
    else if (command == "left")
    {
        submarineCol -= 1;
    }
    else if (command == "right")
    {
        submarineCol += 1;
    }

    if (matrix[submarineRow, submarineCol] == '-')
    {
        continue;

    }
    else if (matrix[submarineRow, submarineCol] == '*')
    {
        minesCount++;
        matrix[submarineRow, submarineCol] = '-';
    }
    else if (matrix[submarineRow, submarineCol] == 'C')
    {
        cruisersCount++;
        matrix[submarineRow, submarineCol] = '-';
    }
}

matrix[submarineRow, submarineCol] = 'S';

if (cruisersCount == 3)
{
    Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
}
else
{
    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarineRow}, {submarineCol}]!");
}
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
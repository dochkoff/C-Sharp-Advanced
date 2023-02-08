using GenericSwapMethodIntegers;

Box<int> box = new();

int inputNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < inputNumber; i++)
{
    int item = int.Parse(Console.ReadLine());

    box.Add(item);
}

int[] indexes = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

box.Swap(indexes[0], indexes[1]);

Console.WriteLine(box.ToString());
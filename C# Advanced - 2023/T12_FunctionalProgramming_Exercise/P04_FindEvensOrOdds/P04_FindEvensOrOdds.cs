Func<int, int, List<int>> generateRange = (start, end) =>
{
    List<int> range = new();

    for (int i = start; i <= end; i++)
    {
        range.Add(i);
    }

    return range;
};

Predicate<int> match;

int[] range = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string command = Console.ReadLine();

List<int> numbers = generateRange(range[0], range[1]);

if (command == "even")
{
    match = numbers => numbers % 2 == 0;
}
else
{
    match = numbers => numbers % 2 != 0;
}

foreach (var number in numbers)
{
    if (match(number))
    {
        Console.Write(number + " ");
    }
}
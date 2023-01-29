List<Predicate<int>> predicates = new();

int endOfRange = int.Parse(Console.ReadLine());

HashSet<int> deviders = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();

int[] numbers = Enumerable.Range(1, endOfRange).ToArray();

foreach (var devider in deviders)
{
    predicates.Add(n => n % devider == 0);
}

foreach (var number in numbers)
{
    bool isDevisible = true;

    foreach (var match in predicates)
    {
        if (!match(number))
        {
            isDevisible = false;
            break;
        }
    }

    if (isDevisible)
    {
        Console.Write($"{number} ");
    }
}
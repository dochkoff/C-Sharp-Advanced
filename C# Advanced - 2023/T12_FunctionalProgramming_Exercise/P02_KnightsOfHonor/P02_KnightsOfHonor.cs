string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string[]> printNames = names =>
{
    foreach (var name in names)
    {
        Console.WriteLine($"Sir {name}");
    }
};

printNames(names);
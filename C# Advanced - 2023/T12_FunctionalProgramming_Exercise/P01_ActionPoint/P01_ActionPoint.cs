string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string[]> printNames = names => Console.WriteLine(string.Join(Environment.NewLine, names));

printNames(names);
List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int devider = int.Parse(Console.ReadLine());

Func<List<int>, Predicate<int>, List<int>> excludeDevisible = (numbers, match) =>
{
    List<int> result = new();

    foreach (var number in numbers)
    {
        if (!match(number))
        {
            result.Add(number);
        }
    }

    return result;
};

Func<List<int>, List<int>> reverce = numbers =>
{
    List<int> result = new();

    for (int i = numbers.Count - 1; i >= 0; i--)
    {
        result.Add(numbers[i]);
    }

    return result;
};




numbers = excludeDevisible(numbers, n => n % devider == 0);
numbers = reverce(numbers);

Console.WriteLine(string.Join(" ", numbers));
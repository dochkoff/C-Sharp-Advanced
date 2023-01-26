Func<HashSet<int>, int> min = numbers =>
{
    int min = int.MaxValue;

    foreach (var num in numbers)
    {
        if (num < min)
        {
            min = num;
        }
    }
    return min;
};

HashSet<int> nums = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();

Console.WriteLine(min(nums));
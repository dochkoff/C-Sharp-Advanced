List<string> people = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

Dictionary<string, Predicate<string>> filters = new();

string command = string.Empty;

while ((command = Console.ReadLine()) != "Print")
{
    string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries);

    string action = tokens[0];
    string filterType = tokens[1];
    string filterParam = tokens[2];

    if (action == "Add filter")
    {
        filters.Add(filterType + filterParam, GetPredicate(filterType, filterParam));
    }
    else
    {
        filters.Remove(filterType + filterParam);
    }

}

foreach (var filter in filters)
{
    people.RemoveAll(filter.Value);
}

Console.WriteLine($"{string.Join(" ", people)}");


static Predicate<string> GetPredicate(string filterType, string filterParam)
{
    switch (filterType)
    {
        case "Starts with":
            return p => p.StartsWith(filterParam);
        case "Ends with":
            return p => p.EndsWith(filterParam);
        case "Contains":
            return p => p.Contains(filterParam);
        case "Length":
            return p => p.Length == int.Parse(filterParam);
        default:
            return default;
    }
}
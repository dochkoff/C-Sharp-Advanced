Queue<int> textiles = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Stack<int> medicaments = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Dictionary<string, int> healingItems = new();
healingItems["Patch"] = 30;
healingItems["Bandage"] = 40;
healingItems["MedKit"] = 100;

Dictionary<string, int> items = new Dictionary<string, int>();


//int patchCounter = 0;
//int bandageCounter = 0;
//int medKitCounter = 0;

while (textiles.Any() && medicaments.Any())
{
    int textile = textiles.Peek();
    int medicament = medicaments.Peek();
    int sum = textile + medicament;

    foreach (var kvp in healingItems)
    {
        if (kvp.Value == sum)
        {
            if (kvp.Key == "Patch")
            {
                AddItem(items, "Patch");
            }
            else if (kvp.Key == "Bandage")
            {
                AddItem(items, "Bandage");
            }
            else if (kvp.Key == "MedKit")
            {
                AddItem(items, "MedKit");
            }
            textiles.Dequeue();
            medicaments.Pop();
        }


    }

    if (sum > 100)
    {
        AddItem(items, "MedKit");
        textiles.Dequeue();
        medicaments.Pop();
        int lastElement = medicaments.Pop();
        int diffrerence = sum - 100;
        medicaments.Push(lastElement + diffrerence);
        continue;
    }

    if (sum != 30 && sum != 40 && sum != 100)
    {
        textiles.Dequeue();
        int lastElement = medicaments.Pop();
        medicaments.Push(lastElement + 10);
    }
}

if (textiles.Count == 0 && medicaments.Count == 0)
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (textiles.Count == 0)
{
    Console.WriteLine("Textiles are empty.");
}
else if (medicaments.Count == 0)
{
    Console.WriteLine("Medicaments are empty.");
}

foreach (var item in items.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

if (medicaments.Count > 0)
{
    Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
}

if (textiles.Count > 0)
{
    Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
}

static void AddItem(Dictionary<string, int> items, string itemName)
{
    if (!items.ContainsKey(itemName))
    {
        items.Add(itemName, 1);
    }
    else
    {
        items[itemName]++;
    }
}
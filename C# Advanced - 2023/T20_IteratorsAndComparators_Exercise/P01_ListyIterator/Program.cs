using ListyIterator;

List<string> items = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Skip(1)
    .ToList();

ListyIterator<string> collection = new(items);

string command = string.Empty;

while ((command = Console.ReadLine()) != "END")
{
    if (command == "Move")
    {
        Console.WriteLine(collection.Move());
    }
    else if (command == "HasNext")
    {
        Console.WriteLine(collection.HasNext());
    }
    else if (command == "Print")
    {
        collection.Print();
    }
    else
    {
        Console.WriteLine("Invalid Operation!");
    }
}
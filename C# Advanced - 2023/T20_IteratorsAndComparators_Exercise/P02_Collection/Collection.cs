using ListyIterator;

List<string> items = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Skip(1)
    .ToList();

ListyIterator<string> collection = new(items);

string command = string.Empty;

while ((command = Console.ReadLine()) != "END")
{
    switch (command)
    {
        case "Move":
            Console.WriteLine(collection.Move());
            break;
        case "HasNext":
            Console.WriteLine(collection.HasNext());
            break;
        case "Print":
            try
            {
                collection.Print();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }

            break;
        case "PrintAll":
            foreach (var item in collection)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            break;
    }
}

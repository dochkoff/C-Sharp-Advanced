int nameLenght = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Predicate<string> filter = name => name.Length <= nameLenght;

foreach (var name in names)
{
    if (filter(name))
    {
        Console.WriteLine(name);
    }
}
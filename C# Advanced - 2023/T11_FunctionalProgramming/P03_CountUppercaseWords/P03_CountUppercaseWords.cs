Predicate<string> filterbyUppercase = s => s[0] == char.ToUpper(s[0]);

string[] words = Console.ReadLine()
    .Split()
    .Where(s => filterbyUppercase(s))
    .ToArray();

foreach (var item in words)
{
    Console.WriteLine(item);
}
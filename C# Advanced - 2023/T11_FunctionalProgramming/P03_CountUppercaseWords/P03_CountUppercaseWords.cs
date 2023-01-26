Predicate<string> filterbyUppercase = s => s[0] == char.ToUpper(s[0]) && char.IsLetter(s[0]);

string[] words = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Where(s => filterbyUppercase(s))
    .ToArray();

foreach (var item in words)
{
    Console.WriteLine(item);
}
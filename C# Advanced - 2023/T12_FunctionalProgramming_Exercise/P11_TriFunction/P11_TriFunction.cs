Func<string, int, bool> checkEqualOrLargerNameSum =
    (name, sum) => name.Sum(ch => ch) >= sum;

int sum = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Func<string[], int, Func<string, int, bool>, string> getFirstName =
    (name, sum, match) => name.FirstOrDefault(name => match(name, sum));

Console.WriteLine(getFirstName(names, sum, checkEqualOrLargerNameSum));
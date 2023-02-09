
using Tuple;

string[] personInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] drinkBeer = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

CustomTuple<string, string> personTuple =
    new($"{personInfo[0]} {personInfo[1]}", personInfo[2]);

CustomTuple<string, int> beerTuple =
    new(drinkBeer[0], int.Parse(drinkBeer[1]));

CustomTuple<int, double> numbersTuple =
    new(int.Parse(numbers[0]), double.Parse(numbers[1]));

Console.WriteLine(personTuple);
Console.WriteLine(beerTuple);
Console.WriteLine(numbersTuple.ToString());
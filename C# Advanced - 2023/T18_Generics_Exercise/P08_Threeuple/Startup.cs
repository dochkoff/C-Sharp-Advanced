using CustomThreeuple;

string[] personInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] drunkInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] bankInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

Threeuple<string, string, string> person =
    new($"{personInfo[0]} {personInfo[1]}", personInfo[2], string.Join(" ", personInfo[3..]));

Threeuple<string, int, bool> isDrunk =
    new(drunkInfo[0], int.Parse(drunkInfo[1]), drunkInfo[2] == "drunk");

Threeuple<string, double, string> accBanalce =
    new(bankInfo[0], double.Parse(bankInfo[1]), bankInfo[2]);

Console.WriteLine(person);
Console.WriteLine(isDrunk);
Console.WriteLine(accBanalce);
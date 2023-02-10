﻿using Stack;

CustomStack<int> stack = new();

string command = string.Empty;
while ((command = Console.ReadLine()) != "END")
{
    string[] items = command
    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

    string action = items[0];

    if (action == "Push")
    {
        int[] elementsToPush = items
            .Skip(1)
            .Select(int.Parse)
            .ToArray();

        foreach (var item in elementsToPush)
        {
            stack.Push(item);
        }
    }
    else if (action == "Pop")
    {
        try
        {
            stack.Pop();
        }
        catch (InvalidOperationException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}

foreach (var item in stack)
{
    Console.WriteLine(item);
}
foreach (var item in stack)
{
    Console.WriteLine(item);
}
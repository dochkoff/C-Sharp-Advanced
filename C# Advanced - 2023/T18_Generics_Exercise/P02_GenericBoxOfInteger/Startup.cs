
using GenericBoxOfInteger;

Box<int> box = new();

int numberOfInputes = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfInputes; i++)
{
    int item = int.Parse(Console.ReadLine());

    box.Add(item);
}

Console.WriteLine(box.ToString());
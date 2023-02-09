using GenericCountMethodStrings;

int numOfItems = int.Parse(Console.ReadLine());

Box<string> box = new();

for (int i = 0; i < numOfItems; i++)
{
    string item = Console.ReadLine();
    box.Add(item);
}

string element = Console.ReadLine();

Console.WriteLine(box.Count(element));
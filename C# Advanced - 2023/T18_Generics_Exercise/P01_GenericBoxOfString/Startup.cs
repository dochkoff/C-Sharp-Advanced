using GenericBoxOfString;

Box<string> box = new();

int numberOfInputes = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfInputes; i++)
{
    string item = Console.ReadLine();

    box.Add(item);
}

Console.WriteLine(box.ToString());
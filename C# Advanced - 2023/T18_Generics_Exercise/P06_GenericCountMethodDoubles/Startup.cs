using GenericCountMethodDoubles;

int numOfItems = int.Parse(Console.ReadLine());

Box<double> box = new();

for (int i = 0; i < numOfItems; i++)
{
    double item = double.Parse(Console.ReadLine());
    box.Add(item);
}

double element = double.Parse(Console.ReadLine());

Console.WriteLine(box.Count(element));
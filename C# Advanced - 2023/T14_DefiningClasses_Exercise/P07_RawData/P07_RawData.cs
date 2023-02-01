using P07_RawData;

List<Car> cars = new();

int count = int.Parse(Console.ReadLine());



for (int i = 0; i < count; i++)
{
    string[] carProps = Console.ReadLine()
    .Split();

    Car car = new(
        carProps[0],
        int.Parse(carProps[1]),
        int.Parse(carProps[2]),
        int.Parse(carProps[3]),
         carProps[4],
        double.Parse(carProps[5]),
        int.Parse(carProps[6]),
        double.Parse(carProps[7]),
        int.Parse(carProps[8]),
        double.Parse(carProps[9]),
        int.Parse(carProps[10]),
        double.Parse(carProps[11]),
        int.Parse(carProps[12])
        );

    cars.Add(car);
}

string command = Console.ReadLine();

string[] filteredModels;

if (command == "fragile")
{
    filteredModels = cars
        .Where(c => c.Cargo.CargoType == "fragile" && c.Tires.Any(t => t.Pressure < 1))
        .Select(c => c.Model)
        .ToArray();
}
else
{
    filteredModels = cars
        .Where(c => c.Cargo.CargoType == "flammable" && c.Engine.EnginePower > 250)
        .Select(c => c.Model)
        .ToArray();
}

Console.WriteLine(string.Join(Environment.NewLine, filteredModels));
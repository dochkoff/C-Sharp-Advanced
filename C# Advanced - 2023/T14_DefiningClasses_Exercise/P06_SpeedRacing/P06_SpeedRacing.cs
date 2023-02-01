using P06_SpeedRacing;

int count = int.Parse(Console.ReadLine());

HashSet<Car> cars = new();

for (int i = 0; i < count; i++)
{
    string[] carProps = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    Car car = new(carProps[0], double.Parse(carProps[1]), double.Parse(carProps[2]));

    cars.Add(car);
}

while (true)
{
    string command = Console.ReadLine();

    if (command == "End")
    {
        break;
    }

    string[] cmdArgs = command
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string model = cmdArgs[1];
    double distance = double.Parse(cmdArgs[2]);

    foreach (var car in cars)
    {
        if (car.Model == model)
        {
            car.Drive(distance);
        }
    }
}

foreach (var car in cars)
{
    Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
}
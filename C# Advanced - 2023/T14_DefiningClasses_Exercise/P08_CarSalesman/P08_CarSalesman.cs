using P08_CarSalesman;

List<Engine> engines = new();
List<Car> cars = new();

int numOfEngines = int.Parse(Console.ReadLine());

for (int i = 0; i < numOfEngines; i++)
{
    string[] engineProps = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string model = engineProps[0];
    int power = int.Parse(engineProps[1]);

    Engine engine = new(model, power);

    if (engineProps.Length == 3)
    {
        if (int.TryParse(engineProps[2], out int displacement))
        {
            engine.Displacement = displacement;
        }
        else
        {
            string efficiency = engineProps[2];
            engine.Efficiency = efficiency;
        }
    }
    else if (engineProps.Length == 4)
    {
        int displacement = int.Parse(engineProps[2]);
        string efficiency = engineProps[3];

        engine.Displacement = displacement;
        engine.Efficiency = efficiency;
    }

    engines.Add(engine);
}

int numOfCars = int.Parse(Console.ReadLine());

for (int i = 0; i < numOfCars; i++)
{
    string[] carProps = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string model = carProps[0];

    Engine carEngine = new();
    foreach (var engin in engines)
    {
        if (engin.Model == carProps[1])
        {
            carEngine = engin;
        }
    }

    Car car = new(model, carEngine);

    if (carProps.Length == 3)
    {
        if (int.TryParse(carProps[2], out int weight))
        {
            car.Weight = weight;
        }
        else
        {
            car.Color = carProps[2];
        }


    }
    else if (carProps.Length == 4)
    {
        int weight = int.Parse(carProps[2]);
        string color = carProps[3];

        car.Weight = weight;
        car.Color = color;
    }

    cars.Add(car);
}

foreach (var car in cars)
{
    Console.WriteLine(car);
}
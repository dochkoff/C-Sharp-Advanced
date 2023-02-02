using P08_CarSalesman;

List<Engine> engines = new();
List<Car> cars = new();

int numOfEngines = int.Parse(Console.ReadLine());

for (int i = 0; i < numOfEngines; i++)
{
    string[] engineProps = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    Engine engine = EngineCreate(engineProps);

    engines.Add(engine);
}

int numOfCars = int.Parse(Console.ReadLine());

for (int i = 0; i < numOfCars; i++)
{
    string[] carProps = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    Car car = CarCreate(engines, carProps);

    cars.Add(car);
}

foreach (var car in cars)
{
    Console.WriteLine(car);
}

static Engine EngineCreate(string[] engineProps)
{
    string model = engineProps[0];
    int power = int.Parse(engineProps[1]);

    Engine engine = new(model, power);

    if (engineProps.Length > 2)
    {
        if (int.TryParse(engineProps[2], out int displacement))
        {
            engine.Displacement = int.Parse(engineProps[2]);
        }
        else
        {
            engine.Efficiency = engineProps[2];
        }

        if (engineProps.Length > 3)
        {
            engine.Efficiency = engineProps[3];
        }
    }

    return engine;
}

static Car CarCreate(List<Engine> engines, string[] carProps)
{
    string model = carProps[0];

    Engine carEngine = engines.Find(e => e.Model == carProps[1]);

    Car car = new(model, carEngine);

    if (carProps.Length > 2)
    {
        if (int.TryParse(carProps[2], out int weight))
        {
            car.Weight = int.Parse(carProps[2]);
        }
        else
        {
            car.Color = carProps[2];
        }

        if (carProps.Length > 3)
        {
            car.Color = carProps[3];
        }
    }

    return car;
}
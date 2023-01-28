using CarManufacturer;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            List<Tire[]> tiresList = new();
            List<Engine> engins = new();
            List<Car> cars = new();

            string command;

            while ((command = Console.ReadLine()) != "No more tires")
            {
                double[] tireProps = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                Tire[] tires = new Tire[4]
                {
                    new Tire ((int)tireProps[0],tireProps[1]),
                    new Tire ((int)tireProps[2],tireProps[3]),
                    new Tire ((int)tireProps[4],tireProps[5]),
                    new Tire ((int)tireProps[6],tireProps[7])
                };

                tiresList.Add(tires);
            }

            while ((command = Console.ReadLine()) != "Engines done")
            {
                double[] engineProps = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                Engine engine = new Engine((int)engineProps[0], engineProps[1]);

                engins.Add(engine);
            }

            while ((command = Console.ReadLine()) != "Show special")
            {
                string[] carProps = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(carProps[0], carProps[1], int.Parse(carProps[2]), double.Parse(carProps[3]), double.Parse(carProps[4]), engins[int.Parse(carProps[5])], tiresList[int.Parse(carProps[6])]);

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                double sumOfTiresPresure = car.Tires[0].Pressure + car.Tires[1].Pressure + car.Tires[2].Pressure + car.Tires[3].Pressure;

                if (car.Year >= 2017
                    && car.Engine.HorsePower > 330
                    && sumOfTiresPresure >= 9
                    && sumOfTiresPresure <= 10)
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI());
                }
            }
        }
    }
}
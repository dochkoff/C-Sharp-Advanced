using CarManufacturer;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car();

            car.Make = "Toyota";
            car.Model = "Avensis";
            car.Year = 2006;
            car.FuelQuantity = 200;
            car.FuelConsumption = 10;

            Engine engin = new Engine(150, 2200);

            car.Engine = engin;

            Tire[] tires = new Tire[4]
            {
                new Tire(1,2.5),
                new Tire(1,2.5),
                new Tire(2,2.2),
                new Tire(2,2.2),
            };

            car.Drive(10);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
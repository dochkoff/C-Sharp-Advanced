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

            car.Drive(10);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
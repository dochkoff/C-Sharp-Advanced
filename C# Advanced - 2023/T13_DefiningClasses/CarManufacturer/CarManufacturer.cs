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

            Console.WriteLine($"My car is {car.Make} {car.Model} from {car.Year} year.");
        }
    }
}

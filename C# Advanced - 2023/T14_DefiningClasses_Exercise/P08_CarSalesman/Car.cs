using System;
namespace P08_CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            Weight = weight;
        }

        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine, weight)
        {
            Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            string displacement = Engine.Displacement == 0 ? "n/a" : Engine.Displacement.ToString();

            string efficiency = Engine.Efficiency ?? "n/a";

            string weight = Weight == 0 ? "n/a" : Weight.ToString(); // if Weight equals 0 - default value, then string takes value "n/a" else takes string value of Weight for example "1300"

            string color = Color ?? "n/a"; // if Color is null then string takes value "n/a" else it takes Color value for example "Silver"

            return $"{Model}:{Environment.NewLine}" +
               $"  {Engine.Model}:{Environment.NewLine}" +
               $"    Power: {Engine.Power}{Environment.NewLine}" +
               $"    Displacement: {displacement}{Environment.NewLine}" +
               $"    Efficiency: {efficiency}{Environment.NewLine}" +
               $"  Weight: {weight}{Environment.NewLine}" +
               $"  Color: {color}";
        }
    }
}


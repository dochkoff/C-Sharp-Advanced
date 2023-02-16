using System.Collections.Generic;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor = new List<CPU>();
        }

        public string Model { get; set; }
        public int Capacity { get; set; }
        public List<CPU> Multiprocessor { get; set; }

        public int Count => Multiprocessor.Count;

        public void Add(CPU processor)
        {
            if (Multiprocessor.Count < Capacity)
            {
                Multiprocessor.Add(processor);
            }
        }

        public bool Remove(string brand)
        {
            bool containsBrand = false;
            CPU removedCPU = null;

            foreach (var processor in Multiprocessor)
            {
                if (processor.Brand == brand)
                {
                    containsBrand = true;
                    removedCPU = processor;
                }
            }

            if (containsBrand == true)
            {
                Multiprocessor.Remove(removedCPU);
            }

            return containsBrand;
        }

        public CPU MostPowerful()
        {
            CPU peekCPU = Multiprocessor[0];

            foreach (var processor in Multiprocessor)
            {
                if (processor.Frequency > peekCPU.Frequency)
                {
                    peekCPU = processor;
                }
            }

            return peekCPU;
        }

        public CPU GetCPU(string brand)
        {
            foreach (var processor in Multiprocessor)
            {
                if (processor.Brand == brand)
                {
                    return processor;
                }
            }

            return null;
        }

        public string Report()
        {
            string report = $"CPUs in the Computer {this.Model}:";

            foreach (var processor in Multiprocessor)
            {
                report += processor.ToString() + "\n";
            }

            return report.TrimEnd();
        }
    }
}

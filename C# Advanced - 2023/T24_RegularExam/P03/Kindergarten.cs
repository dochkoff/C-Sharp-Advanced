using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }

        public int ChildrenCount => Registry.Count;

        public bool AddChild(Child child)
        {
            if (Registry.Count < Capacity)
            {
                Registry.Add(child);
                return true;
            }
            return false;
        }

        public bool RemoveChild(string childFullName)
        {
            string[] names = childFullName
                .Split(" ", System.StringSplitOptions.RemoveEmptyEntries);

            string currenChildFirstName = names[0];
            string currenChildLastName = names[1];

            foreach (var child in Registry)
            {
                if (child.FirstName == currenChildFirstName && child.LastName == currenChildLastName)
                {
                    Registry.Remove(child);
                    return true;
                }
            }
            return false;
        }

        public Child GetChild(string childFullName)
        {
            string[] names = childFullName
                .Split(" ", System.StringSplitOptions.RemoveEmptyEntries);

            string currenChildFirstName = names[0];
            string currenChildLastName = names[1];

            foreach (var child in Registry)
            {
                if (child.FirstName == currenChildFirstName && child.LastName == currenChildLastName)
                {
                    Registry.Remove(child);
                    return child;
                }
            }
            return null;
        }

        public string RegistryReport()
        {


            StringBuilder sb = new();

            sb.AppendLine($"Registered children in {Name}:");

            foreach (var child in Registry.OrderByDescending(c => c.Age).ThenBy(c => c.LastName).ThenBy(c => c.FirstName))
            {
                sb.AppendLine(child.ToString());
            }

            return sb.ToString().TrimEnd();


        }
    }
}
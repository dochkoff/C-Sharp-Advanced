using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < entries; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                decimal grade = decimal.Parse(info[1]);

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<decimal>());
                }

                studentsGrades[name].Add(grade);
            }

            foreach (var kvp in studentsGrades)
            {
                Console.Write(kvp.Key + " -> ");

                foreach (var item in kvp.Value)
                {
                    Console.Write($"{item:F2} ");
                }

                Console.WriteLine($"(avg: {kvp.Value.Average():F2})");

            }
        }
    }
}
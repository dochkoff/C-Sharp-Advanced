using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> people = new();

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string[] personProps = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(personProps[0], int.Parse(personProps[1]));

                if (person.Age > 30)
                {
                    people.Add(person);
                }
            }

            List<Person> orderedPeople = people.OrderBy(p => p.Name).ToList();

            foreach (var person in orderedPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

            //***P03***
            //Family family = new();

            //int count = int.Parse(Console.ReadLine());

            //for (int i = 0; i < count; i++)
            //{
            //    string[] personProps = Console.ReadLine()
            //        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //    Person person = new Person(personProps[0], int.Parse(personProps[1]));
            //    family.AddMember(person);
            //}

            //Person oldestPerson = family.GetOldestMember();

            //Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
using System;
using System.Collections.Generic;

List<Person> people = ReadPeople();

string filterType = Console.ReadLine();
int filterValue = int.Parse(Console.ReadLine());

Func<Person, int, bool> filter = GetFilter(filterType);

people = people.Where(p => filter(p, filterValue)).ToList();

Action<Person> formatter = GetFormatter(Console.ReadLine());

foreach (var person in people)
{
    formatter(person);
}

List<Person> ReadPeople()
{
    List<Person> personList = new();

    int numOfPersons = int.Parse(Console.ReadLine());

    for (int i = 0; i < numOfPersons; i++)
    {
        string[] personInfo = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries);

        personList.Add(new Person() { Name = personInfo[0], Age = int.Parse(personInfo[1]) });
    }
    return personList;
}

Func<Person, int, bool> GetFilter(string filterTupe)
{
    if (filterTupe == "younger")
    {
        return (p, value) => p.Age < value;
    }
    else
    {
        return (Person p, int value) => p.Age >= value;
    }
}

Action<Person> GetFormatter(string formatType)
{
    if (formatType == "name age")
    {
        return p => Console.WriteLine($"{p.Name} - {p.Age}");
    }
    else if (formatType == "name")
    {
        return p => Console.WriteLine($"{p.Name}");
    }
    else if (formatType == "age")
    {
        return p => Console.WriteLine($"{p.Age}");
    }

    return null;
}

class Person
{
    public string Name;
    public int Age;
}
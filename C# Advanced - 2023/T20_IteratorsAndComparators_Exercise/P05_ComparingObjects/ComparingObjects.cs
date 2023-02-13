using ComparingObjects;

List<Person> people = new();

string command = string.Empty;

while ((command = Console.ReadLine()) != "END")
{
    string[] personProps = command
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string name = personProps[0];
    int age = int.Parse(personProps[1]);
    string town = personProps[2];

    Person person = new Person(name, age, town);
    people.Add(person);
}

int position = int.Parse(Console.ReadLine());
int matches = 0;

foreach (var person in people)
{
    if (person.CompareTo(people[position - 1]) == 0)
    {
        matches++;
    }
}

if (matches == 1)
{
    Console.WriteLine("No matches");
}
else
{
    Console.WriteLine($"{matches} {people.Count - matches} {people.Count}");
}
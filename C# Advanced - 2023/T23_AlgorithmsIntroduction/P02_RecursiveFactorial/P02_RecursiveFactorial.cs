int number = int.Parse(Console.ReadLine());

Console.WriteLine(FactorialRecursion(number));

static int FactorialRecursion(int number)
{
    if (number == 0)
    {
        return 1;
    }

    return number * FactorialRecursion(number - 1);
}
int[] caffeine = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] drinks = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Stack<int> caffeineStack = new();
Queue<int> drinksQueue = new();
int totalCaffeineIntake = 0;

for (int i = 0; i < caffeine.Length; i++)
{
    caffeineStack.Push(caffeine[i]);
}

for (int i = 0; i < drinks.Length; i++)
{
    drinksQueue.Enqueue(drinks[i]);
}

while (caffeineStack.Count > 0 && drinksQueue.Count > 0)
{
    int currentCaffeine = caffeineStack.Peek();
    int currentDrink = drinksQueue.Peek();
    int currentCaffeineIntake = currentCaffeine * currentDrink;

    if (currentCaffeineIntake + totalCaffeineIntake <= 300)
    {
        totalCaffeineIntake += currentCaffeineIntake;
        caffeineStack.Pop();
        drinksQueue.Dequeue();
    }
    else
    {
        caffeineStack.Pop();
        int drinkToMove = drinksQueue.Dequeue();
        drinksQueue.Enqueue(drinkToMove);
        totalCaffeineIntake -= 30;

        if (totalCaffeineIntake < 0)
        {
            totalCaffeineIntake = 0;
        }
    }
}

if (drinksQueue.Count > 0)
{
    Console.WriteLine($"Drinks left: {string.Join(", ", drinksQueue)}");
}
else
{
    Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
}

Console.WriteLine($"Stamat is going to sleep with {totalCaffeineIntake} mg caffeine.");
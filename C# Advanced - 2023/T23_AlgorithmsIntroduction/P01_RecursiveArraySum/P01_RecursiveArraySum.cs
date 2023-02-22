int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Console.WriteLine(ArraySum(array, 0));

static int ArraySum(int[] arr, int index)
{
    if (index == arr.Length - 1)
    {
        return arr[index];
    }

    return arr[index] + ArraySum(arr, index + 1);
}
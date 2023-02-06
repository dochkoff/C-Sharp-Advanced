using P03_CustomQueue;

CustomQueue customQueue = new();

customQueue.Enqueue(10);
customQueue.Enqueue(11);
customQueue.Enqueue(12);
customQueue.Enqueue(13);
customQueue.Enqueue(14);

customQueue.ForEach(i => Console.Write(i + " "));
Console.WriteLine();

Console.WriteLine(customQueue.Dequeue());

Console.WriteLine(customQueue.Peek());

customQueue.Clear();
Console.WriteLine(customQueue.Count);
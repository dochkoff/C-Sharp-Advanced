using P02_CustomStack;

CustomStack customStack = new();

customStack.Push(10);
customStack.Push(11);
customStack.Push(12);
customStack.Push(13);
customStack.Push(14);

Console.WriteLine(customStack.Pop());

Console.WriteLine(customStack.Peek());

customStack.ForEach(i => Console.Write(i + " "));
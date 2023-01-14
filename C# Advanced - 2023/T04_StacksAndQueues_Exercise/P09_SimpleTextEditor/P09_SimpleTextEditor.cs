using System;
using System.Linq;
using System.Collections.Generic;

namespace P09_SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            string text = string.Empty;
            Stack<string> undoChanges = new Stack<string>();

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] command = Console.ReadLine()
                    .Split();

                int commandIndex = int.Parse(command[0]);

                if (commandIndex == 1)
                {
                    undoChanges.Push(text);
                    text = text + command[1];
                }
                else if (commandIndex == 2)
                {
                    undoChanges.Push(text);
                    int erasedElementsCount = int.Parse(command[1]);
                    text = text.Remove(text.Length - erasedElementsCount);
                }
                else if (commandIndex == 3)
                {
                    int indexOfElement = int.Parse(command[1]) - 1;
                    Console.WriteLine(text.ElementAt(indexOfElement));
                }
                else if (commandIndex == 4)
                {
                    text = undoChanges.Pop();
                    Console.WriteLine(text);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;


namespace P06_SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songsQueue = new Queue<string>
                (Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries));



            while (songsQueue.Any())
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (command[0] == "Add")
                {
                    string NewSongName = string.Join(" ", command).Substring(4);

                    if (songsQueue.Contains(NewSongName))
                    {
                        Console.WriteLine($"{NewSongName} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(NewSongName);
                    }
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
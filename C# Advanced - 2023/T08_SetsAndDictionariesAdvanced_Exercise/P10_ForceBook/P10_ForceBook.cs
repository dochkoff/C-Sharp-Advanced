using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedSet<string>> sideAndUser = new();
            string command;
            while ((command = Console.ReadLine()) != "Lumpawaroo")
            {
                string forceSide;
                string forceUser;
                if (command.Contains("|"))
                {
                    string[] cmdArgs = command.Split(" | ");
                    forceSide = cmdArgs[0];
                    forceUser = cmdArgs[1];

                    if (!sideAndUser.ContainsKey(forceSide))
                    {
                        sideAndUser.Add(forceSide, new SortedSet<string>());
                    }

                    sideAndUser[forceSide].Add(forceUser);
                }
                else if (command.Contains("->"))
                {
                    string[] cmdArgs = command.Split(" -> ");
                    forceSide = cmdArgs[1];
                    forceUser = cmdArgs[0];

                    //if (!sideAndUser.ContainsKey(forceSide))
                    //{
                    //    sideAndUser.Add(forceSide, new SortedSet<string>());
                    //}



                    foreach (var keyValuePair in sideAndUser)
                    {
                        if (keyValuePair.Value.Contains(forceUser))
                        {
                            keyValuePair.Value.Remove(forceUser);
                        }
                    }

                    sideAndUser[forceSide].Add(forceUser);

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }


            }

            foreach (var kvp in sideAndUser)
            {
                if (kvp.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count()}");

                    foreach (var user in kvp.Value)
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}

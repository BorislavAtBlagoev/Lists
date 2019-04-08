using System;
using System.Linq;
using System.Collections.Generic;


namespace ListExercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> finalList = ImplementCommands(numberOfCommands).ToList();
            foreach (var members in finalList)
            {
                Console.WriteLine(members);
            }
            Console.ReadLine();
        }

        static List<string> ImplementCommands(int numberOfCommands)
        {
            List<string> guestList = new List<string>();
            string[] enterCommand = new string[4];

            for (int i = 0; i < numberOfCommands; i++)
            {
                enterCommand = Console.ReadLine().Split(" ").ToArray();

                if (enterCommand[2] == "going!")
                {
                    if (guestList.Contains(enterCommand[0]))
                    {
                        Console.WriteLine($"{enterCommand[0]} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(enterCommand[0]);
                    }
                }
                else if (enterCommand[2] == "not")
                {
                    if (!guestList.Contains(enterCommand[0]))
                    {
                        Console.WriteLine($"{enterCommand[0]} is not in the list!");
                    }
                    else
                    {
                        guestList.Remove(enterCommand[0]);
                    }
                }
            }

            return guestList;
        }

    }
}

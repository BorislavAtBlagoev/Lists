using System;
using System.Linq;
using System.Collections.Generic;

namespace ListExercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            ImplementListCommand(inputList);
            Console.WriteLine(string.Join(" ", inputList));
            Console.ReadLine();
        }

        static void ImplementListCommand(List<int> inputList)
        {
            string[] command = Console.ReadLine().Split(" ").ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    inputList.Remove(int.Parse(command[1]));
                }
                else if(command[0] == "Insert")
                {
                    inputList.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }

                command = Console.ReadLine().Split(" ").ToArray();
            }

        }

    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ", ImplementCommands(inputList)));
            Console.ReadLine();
        }

        static List<int> ImplementCommands(List<int> inputList)
        {
            string[] commands = Console.ReadLine().Split(" ").ToArray();

            while (commands[0] != "End")
            {
                switch (commands[0])
                {
                    case "Add":
                        inputList.Add(int.Parse(commands[1]));
                        break;
                    case "Insert":
                        if (inputList.Count - 1 >= int.Parse(commands[2]) && 0 <= int.Parse(commands[2]))
                        {
                            inputList.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        if (inputList.Count - 1 >= int.Parse(commands[1]) && 0 <= int.Parse(commands[1]))
                        {
                            inputList.RemoveAt(int.Parse(commands[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        if (commands[1] == "left")
                        {
                            int temp = 0;
                            for (int i = 0; i < int.Parse(commands[2]); i++)
                            {
                                temp = inputList[0];
                                inputList.RemoveAt(0);
                                inputList.Add(temp);
                            }
                        }
                        else if (commands[1] == "right")
                        {
                            int temp = 0;
                            for (int i = 0; i < int.Parse(commands[2]); i++)
                            {
                                temp = inputList[inputList.Count - 1];
                                inputList.RemoveAt(inputList.Count - 1);
                                inputList.Insert(0, temp);
                            }
                        }
                        break;
                   
                }

                commands = Console.ReadLine().Split(" ").ToArray();
            }
            return inputList;
        }

    }
}

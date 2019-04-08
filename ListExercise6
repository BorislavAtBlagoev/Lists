using System;
using System.Linq;
using System.Collections.Generic;

namespace ListExercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            ImplementingInstructions(digits);
            Console.ReadLine();
        }

        static void ImplementingInstructions(List<int> digits)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split(" ").ToArray();

                switch (command[0])
                {
                    case "Add":
                        digits.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        digits.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        digits.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        digits.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", digits));

        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ListExercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputWagons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int maxCapacityOfWagons = int.Parse(Console.ReadLine());
            AddMembersOrWagons(inputWagons, maxCapacityOfWagons);
            Console.WriteLine(string.Join(" ", inputWagons));
            Console.ReadLine();
        }

        static void AddMembersOrWagons(List<int> wagons, int maxCapacity)
        {
            string[] addMembers = Console.ReadLine().Split(" ").ToArray();

            while (addMembers[0] != "end")
            {
                if (addMembers[0] == "Add")
                {
                    wagons.Add(int.Parse(addMembers[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (maxCapacity >= wagons[i] + int.Parse(addMembers[0]))
                        {
                            wagons[i] += int.Parse(addMembers[0]);
                            break;
                        }
                    }
                }

                addMembers = Console.ReadLine().Split(" ").ToArray();
            }
        }
    }
}

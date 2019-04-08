using System;
using System.Linq;
using System.Collections.Generic;

namespace ListExercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> reverseValues = Console.ReadLine()
                                .Split('|')
                                .Reverse()
                                .ToList();
            
            List<int> number = new List<int>();
            foreach (string p in reverseValues)
            {
                number.AddRange(p.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList()
                                     );
            }

            Console.WriteLine(string.Join(" ", number));
            Console.ReadLine();
        }
    }
}

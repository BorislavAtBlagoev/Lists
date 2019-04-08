using System;
using System.Linq;
using System.Collections.Generic;

namespace ListExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            RemoveNegativesAndReverse(digits);
            Console.ReadLine();
        }

        static void RemoveNegativesAndReverse(List<int> digits)
        {
            
            for (int i = 0; i < digits.Count; i++)
            {
                if (digits[i] < 0)
                {
                    digits.RemoveAt(i);
                    i--;
                }
            }

            if (digits.Count == 0)
            {
                Console.WriteLine("empty");
            }

            digits.Reverse();

            Console.WriteLine(string.Join(" ", digits));
        }
    }
}

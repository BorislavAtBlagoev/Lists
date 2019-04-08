using System;
using System.Linq;
using System.Collections.Generic;

namespace ListsExercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputDigits = Console.ReadLine();
            SumAdjacentEqualsDigits(inputDigits);
            Console.ReadLine();

        }

        static void SumAdjacentEqualsDigits(string inputDigits)
        {
            var digits = inputDigits.Split(' ').Select(double.Parse).ToList();

            for (int i = 1; i < digits.Count; i++)
            {
                if (digits[i] == digits[i - 1])
                {
                    digits[i] += digits[i - 1];
                    digits.RemoveAt(i - 1);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", digits));
        }

    }
}

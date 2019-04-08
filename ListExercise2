using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDigits = Console.ReadLine();
            GaussSum(inputDigits);
            Console.ReadLine();
        }

        static void GaussSum(string inputDigits)
        {
            List<int> digits = inputDigits.Split(' ')
                               .Select(int.Parse)
                               .ToList();

            for (int i = 0; i < digits.Count - 1; i++)
            {

                digits[i] += digits[digits.Count - 1];
                digits.RemoveAt(digits.Count - 1);

            }

            Console.WriteLine(string.Join(" ", digits));

        }

    }
}

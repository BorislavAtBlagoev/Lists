using System;
using System.Linq;
using System.Collections.Generic;

namespace ListExercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            SumOfNumbers(listOfNumbers);
            string text = Console.ReadLine();
            string newText = "";
            Console.WriteLine(FindCorrespondingNumber(listOfNumbers, text, newText));
            Console.ReadLine();
        }
        static void SumOfNumbers(List<int> listOfNumbers)
        {
            int b = 0;
            int a = 0;
            int c = 0;

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                a = listOfNumbers[i];
                while (a > 0)
                {
                    c = a % 10;
                    b = b + c;
                    a = a / 10;
                }
                listOfNumbers[i] = b;
                b = 0;
            }
        }

        static string FindCorrespondingNumber(List<int> listOfNumbers, string text, string newText)
        {
            char temp = ' ';
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] > text.Length)
                {
                    listOfNumbers[i] = listOfNumbers[i] - text.Length;
                    temp = text[listOfNumbers[i] + i];
                    newText = newText + temp;
                    
                }
                else
                {
                    temp = text[listOfNumbers[i] + i];
                    newText = newText + temp;
                    
                }
            }
            return newText;
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ListExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            List<string> listOfProducts = new List<string>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                listOfProducts.Add(Console.ReadLine()); 
            }

            listOfProducts.Sort();

            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.WriteLine($"{i+1}.{listOfProducts[i]}");
            }
            Console.ReadLine();

        }
    }
}

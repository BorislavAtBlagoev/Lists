using System;
using System.Linq;
using System.Collections.Generic;

namespace ListExercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayOfNumbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            SumOfTime(arrayOfNumbers);
            Console.ReadLine();
        }

        static void SumOfTime(double[] arrayOfNumbers)
        {
            double firstCar = 0;
            double secondCar = 0;

            for (int i = 0; i < arrayOfNumbers.Length / 2; i++)
            {
                if (arrayOfNumbers[i] == 0)
                {
                    firstCar *= 0.8;
                }
                else
                {
                    firstCar += arrayOfNumbers[i];
                }
            }

            for (int j = arrayOfNumbers.Length - 1; j > arrayOfNumbers.Length / 2; j--)
            {
                if (arrayOfNumbers[j] == 0)
                {
                    secondCar *= 0.8;
                }
                else
                {
                    secondCar += arrayOfNumbers[j];
                }
            }

            WinnerOfRace(firstCar, secondCar);

        }

        static void WinnerOfRace(double firstCar, double secondCar)
        {
            if (firstCar > secondCar)
            {
                Console.WriteLine($"The winner is right with total time: {secondCar}");
            }
            else if(firstCar < secondCar)
            {
                Console.WriteLine($"The winner is left with total time: {firstCar}");
            }


        }

    }
}

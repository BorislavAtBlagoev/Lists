using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            SumOfTwoLists(firstList, secondList);
            Console.WriteLine();
            SumOfTwoLists2(firstList, secondList);
            Console.ReadLine();

        }

        static void SumOfTwoLists(List<int> firstList, List<int> secondList)
        {

            if (firstList.Count >= secondList.Count)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    if (i < secondList.Count)
                    {
                        for (int j = i; j <= i; j++)
                        {
                            Console.Write($"{firstList[i]} {secondList[j]} ");
                        }
                    }
                    else
                    {
                        Console.Write($"{firstList[i]} ");
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    if (i < firstList.Count)
                    {
                        for (int j = i; j <= i; j++)
                        {
                            Console.Write($"{firstList[i]} {secondList[j]} ");
                        }
                    }
                    else
                    {
                        Console.Write($"{secondList[i]} ");
                    }
                }
            }
        }

        static void SumOfTwoLists2(List<int> firstList, List<int> secondList)
        {

            if (firstList.Count >= secondList.Count)
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    firstList.Insert(i * 2 + 1, secondList[i]);
                }

                foreach (var item in firstList)
                {
                    Console.Write(item + " ");
                }
            }
            else
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    secondList.Insert(i * 2, firstList[i]);
                }
                foreach (var item in secondList)
                {
                    Console.Write(item + " ");
                }
            }

        }
    }
}

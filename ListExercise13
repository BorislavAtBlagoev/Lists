using System;
using System.Linq;
using System.Collections.Generic;

namespace ListExercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            while (!(firstDeck.Count == 0) && !(secondDeck.Count == 0))
            {
                ComporeCardsInDecks(firstDeck, secondDeck);
            }

            PrintResult(firstDeck, secondDeck);
            Console.ReadLine();

        }
        static void ComporeCardsInDecks(List<int> firstDeck, List<int> secondDeck)
        {
            int i = 0;
            if (firstDeck[i] == secondDeck[i])
            {
                firstDeck.RemoveAt(i);
                secondDeck.RemoveAt(i);
            }
            else if (firstDeck[i] > secondDeck[i])
            {
                firstDeck.Add(firstDeck[i]);
                firstDeck.Add(secondDeck[i]);
                firstDeck.RemoveAt(i);
                secondDeck.RemoveAt(i);
            }
            else if (firstDeck[i] < secondDeck[i])
            {
                secondDeck.Add(secondDeck[i]);
                secondDeck.Add(firstDeck[i]);
                secondDeck.RemoveAt(i);
                firstDeck.RemoveAt(i);
                
            }
        }
        
        static void PrintResult(List<int> firstDeck, List<int> secondDeck)
        {
            if (firstDeck.Count > secondDeck.Count)
            {
                Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
            }
        }

    }
}

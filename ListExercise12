using System;
using System.Linq;
using System.Collections.Generic;


namespace ListExercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputSequence = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ", DetonateDigits(inputSequence)));
            Console.ReadLine();
        }

        static int DetonateDigits(List<int> inputSequence)
        {
            int[] specialDigit = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < inputSequence.Count - 1; i++)
            {
                if (specialDigit[0] == inputSequence[i])
                {

                    int a = specialDigit[1];
                    int b = specialDigit[1];

                    if (a + i < inputSequence.Count)
                    {
                        for (int j = 0; j < a; j++)
                        {
                            inputSequence.RemoveAt(i + 1);
                        }
                    }
                    else
                    {
                        a = (inputSequence.Count - 1) - i;
                        for (int j = 0; j < a; j++)
                        {
                            inputSequence.RemoveAt(i + 1);
                        }
                    }

                    if (i >= b)
                    {
                        for (int k = 0; k < b; k++)
                        {
                            inputSequence.RemoveAt(i - 1 - k);
                        }
                    }
                    else
                    {
                        for (int k = 0; k < i; k++)
                        {
                            inputSequence.RemoveAt(i - 1);
                        }
                    }
                }
            }

            inputSequence.RemoveAll(x => x == specialDigit[0]);
            int sum = inputSequence.Sum();
            return sum;
        }

    }
}

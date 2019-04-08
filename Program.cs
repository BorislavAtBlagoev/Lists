using System;
using System.Linq;
using System.Collections.Generic;

namespace ListExercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            bool[] isChange = { false };

            ImplementingInstructions(digits, isChange);

            if (isChange[0] == true)
            {
                Console.WriteLine(string.Join(" ", digits));
            }
            Console.ReadLine();
        }

        static void ImplementingInstructions(List<int> digits, bool[] isChange)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split(" ").ToArray();

                switch (command[0])
                {
                    case "Add":
                        digits.Add(int.Parse(command[1]));
                        isChange[0] = true;
                        break;
                    case "Remove":
                        digits.Remove(int.Parse(command[1]));
                        isChange[0] = true;
                        break;
                    case "RemoveAt":
                        digits.RemoveAt(int.Parse(command[1]));
                        isChange[0] = true;
                        break;
                    case "Insert":
                        digits.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        isChange[0] = true;
                        break;
                    case "Contains":
                        if (digits.Contains(int.Parse(command[1])) == true)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        bool isPrint = false;
                        for (int i = 0; i < digits.Count; i++)
                        {
                            if (digits[i] % 2 == 0)
                            {
                                Console.Write($"{digits[i]} ");
                                isPrint = true;
                            }
                        }
                        if (isPrint == true)
                        {
                            Console.WriteLine();
                        }
                        break;
                    case "PrintOdd":
                        bool isPrint2 = false;
                        for (int i = 0; i < digits.Count; i++)
                        {
                            if (!(digits[i] % 2 == 0))
                            {
                                Console.Write($"{digits[i]} ");
                                isPrint2 = true;
                            }
                        }
                        if (isPrint2 == true)
                        {
                            Console.WriteLine();
                        }
                        break;
                    case "GetSum":
                        Console.WriteLine(digits.Sum());
                        break;
                    case "Filter":
                        bool isPrint3 = false;
                        if ("<" == command[1])
                        {
                            for (int i = 0; i < digits.Count; i++)
                            {
                                if (int.Parse(command[2]) > digits[i])
                                {
                                    Console.Write($"{digits[i]} ");
                                    isPrint3 = true;
                                }
                            }
                        }
                        else if (">" == command[1])
                        {
                            for (int i = 0; i < digits.Count; i++)
                            {
                                if (int.Parse(command[2]) < digits[i])
                                {
                                    Console.Write(digits[i]+" ");
                                    isPrint3 = true;
                                }
                            }
                        }
                        else if ("<=" == command[1])
                        {
                            for (int i = 0; i < digits.Count; i++)
                            {
                                if (int.Parse(command[2]) >= digits[i])
                                {
                                    Console.Write(digits[i] + " ");
                                    isPrint3 = true;
                                }
                            }
                        }
                        else if (">=" == command[1])
                        {
                            for (int i = 0; i < digits.Count; i++)
                            {
                                if (int.Parse(command[2]) <= digits[i])
                                {
                                    Console.Write(digits[i] + " ");
                                    isPrint3 = true;
                                }
                            }
                        }
                        if (isPrint3 == true)
                        {
                            Console.WriteLine();
                        }
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }



        }
    }
}


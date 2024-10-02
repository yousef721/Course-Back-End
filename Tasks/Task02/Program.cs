using System;
using System.Collections.Generic;

namespace Task02
{
    internal class Program
    {
        static void Main()
        {
            bool program = true;
            List<int> list = new List<int>();
            do
            {
                Console.WriteLine();
                Console.WriteLine("Menu Options:");
                Console.WriteLine();
                Console.WriteLine("P - Print number");
                Console.WriteLine("A - Add number");
                Console.WriteLine("M - Display mean of the number");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Found number");
                Console.WriteLine("C - Clear list");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                Console.Write("Enter your choise: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "P":
                    case "p":
                        if (list.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else
                        {
                            Console.Write("[ ");
                            for (int i = 0; i < list.Count; i++)
                            {
                                Console.Write($"{list[i]} ");
                            }
                            Console.WriteLine(']');
                        }
                        break;
                    case "A":
                    case "a":
                        int addNumber;
                        bool check = false;
                        do
                        {
                            Console.Write("Add number: ");
                            addNumber = int.Parse(Console.ReadLine());
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (addNumber == list[i])
                                {
                                    Console.WriteLine("Dont duplicate number, try again");
                                    check = true;
                                }
                                else
                                {
                                    check = false;
                                }
                            }
                        } while (check);
                        {
                            list.Add(addNumber);
                            Console.WriteLine($"{addNumber} added");
                        }
                        break;
                    case "M":
                    case "m":
                        double sumNumber = 0;
                        for (int i = 0; i < list.Count; i++)
                        {
                            sumNumber += list[i];
                        }
                        double mean = sumNumber / list.Count;
                        if (list.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        else
                        {
                            Console.WriteLine($"{mean}");
                        }
                        break;
                    case "S":
                    case "s":
                        int smallestNumber = list[0];
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] < smallestNumber)
                            {
                                smallestNumber = list[i];
                            }
                        }
                        if (list.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }
                        else
                        {
                            Console.WriteLine($"The smallest number is {smallestNumber}");

                        }
                        break;
                    case "L":
                    case "l":
                        int largestNumber = list[0];
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] > largestNumber)
                            {
                                largestNumber = list[i];
                            }
                        }
                        if (list.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }
                        else
                        {
                            Console.WriteLine($"The largest number is {largestNumber}");

                        }
                        break;
                    case "F":
                    case "f":
                        Console.Write("Enter Your Number to search: ");
                        int searchNumber = int.Parse(Console.ReadLine());
                        bool found = false;
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == searchNumber)
                            {
                                Console.WriteLine($"The index number {i}");
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("The number not Found");
                        }
                        break;
                    case "C":
                    case "c":
                        list.Clear();
                        Console.WriteLine("Cleared");
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("Goodbye");
                        program = false;
                        break;
                    default:
                        Console.WriteLine("Unkonw selection, plaese try again");
                        break;
                }
            } while (program);
        }
    }
}


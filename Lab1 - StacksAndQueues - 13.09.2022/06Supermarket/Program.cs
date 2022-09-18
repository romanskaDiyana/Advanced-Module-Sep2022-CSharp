﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace _06Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //06. Supermarket
            //You are given a sequence of input strings, each staying on a separate line. Each input string holds either a customer name, or the command “Paid” or the command “End”. Your task is to read and process the input:
            //• When you receive a customer name, add it to the queue.
            //    • When you receive the "Paid" command, print the customer names from the queue (each at separate line), then empty the queue.
            //    • When you receive the "End" command, print the count of the remaining customers from the queue in the format: "{count} people remaining." and stop processing the commands(see the examples below).

            Queue<string> names = new Queue<string>();
            int countOfPeople = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine($"{countOfPeople} people remaining.");
                    break;
                }

                if (input != "Paid")
                {
                    names.Enqueue(input);
                    countOfPeople++;
                }
                else
                {
                    while (names.Count > 0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }

                    countOfPeople = 0;
                }
            }
        }
    }
}

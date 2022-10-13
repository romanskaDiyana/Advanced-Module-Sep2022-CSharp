using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01. CountSameValuesInArray
            //Create a program that counts in a given array of double values the number of occurrences of each value. 

            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            Dictionary<double, int> numbersOccurences = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numbersOccurences.ContainsKey(number))
                {
                    numbersOccurences.Add(number,0);
                }

                numbersOccurences[number]++;
            }

            foreach (var occurences in numbersOccurences)
            {
                Console.WriteLine($"{occurences.Key} - {occurences.Value} times");
            }
        }
    }
}

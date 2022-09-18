using System;
using System.Collections.Generic;
using System.Linq;

namespace _05PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05. Print Even Numbers
            //Create a program that:
            //• Reads an array of integers and adds them to a queue.
            //• Prints the even numbers separated by ", ".

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(numbers.Where(n => n % 2 == 0));

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02. Stack Sum
            //Create a program that:
            //    • Reads an input of integer numbers and adds them to a stack.
            //    • Reads and executes commands until "end" is received.
            //    • Process the following commands:
            //    ◦ Add<n1> < n2 >: pushes two numbers into the stack
            //    ◦ Remove<n>: removes the n elements from the stack or does nothing if the stack holds less than n elements.
            //    • Prints the sum of the remaining elements of the stack.

            Stack<int> stackOfNumbers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());

            var command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                var splitted = command.Split();

                if (splitted[0] == "add")
                {
                    int firstNumber = int.Parse(splitted[1]);
                    int secondNumber = int.Parse(splitted[2]);

                    stackOfNumbers.Push(firstNumber);
                    stackOfNumbers.Push(secondNumber);
                }

                if (splitted[0] == "remove")
                {
                    int count = int.Parse(splitted[1]);

                    if (count <= stackOfNumbers.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stackOfNumbers.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {stackOfNumbers.Sum()}");
        }
    }
}

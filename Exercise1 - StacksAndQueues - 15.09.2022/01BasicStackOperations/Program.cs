using System;
using System.Collections.Generic;
using System.Linq;

namespace _01BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01. Basic Stack Operations
            //Play around with a stack. You will be given an integer N representing the number of elements to push into the stack, an integer S representing the number of elements to pop from the stack, and finally an integer X, an element that you should look for in the stack. If it's found, print "true" on the console. If it isn't, print the smallest element currently present in the stack. If there are no elements in the sequence, print 0 on the console.

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numberOfElementsToPush = numbers[0];
            int numberOfElementsToPop = numbers[1];
            int numberToLookFor = numbers[2];

            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numberOfElementsToPush; i++)
            {
                stack.Push(integers[i]);
            }

            for (int i = 0; i < numberOfElementsToPop; i++)
            {
                stack.Pop();
            }

            for (int i = 0; i < stack.Count; i++)
            {
                if (stack.Contains(numberToLookFor))
                {
                    Console.WriteLine("true");
                    return;
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine($"{stack.Count}");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}

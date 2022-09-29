using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03. Maximum and Minimum Element
            //You have an empty sequence and you will be given N queries. Each query is one of these three types:
            //1 x – Push the element x into the stack.
            //2 – Delete the element present at the top of the stack.
            //3 – Print the maximum element in the stack.
            //4 – Print the minimum element in the stack.
            //    After you go through all of the queries, print the stack in the following format:
            //"{n}, {n1}, {n2} …, {nn}"

            int numberOfQueries = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numberOfQueries; i++)
            {
                string input = Console.ReadLine();

                if (input == "2")
                {
                    if (stack.Count > 0 )
                    {
                        stack.Pop();
                    }
                }
                else if (input == "3")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (input == "4")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
                else
                {
                    string[] pushInput = input.Split(' ').ToArray();
                    int numberToPush = int.Parse(pushInput[1]);
                    stack.Push(numberToPush);
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}

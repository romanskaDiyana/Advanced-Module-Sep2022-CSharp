using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace _03SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03. Simple Calculator
            //Create a simple calculator that can evaluate simple expressions with only addition and subtraction. There will not be any parentheses. Numbers and operations are space-separated.
            //Solve the problem using a Stack.

            string[] expression = Console.ReadLine().Split();

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < expression.Length; i++)
            {
                stack.Push(expression[i]);

                if (stack.Count == 3)
                {
                    int first = int.Parse(stack.Pop());
                    var sign = stack.Pop();
                    int second = int.Parse(stack.Pop());
                    int result = 0;
                    if (sign == "+")
                    {
                        result = first + second;
                    }

                    if (sign == "-")
                    {
                        result = second - first;
                    }

                    stack.Push(result.ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}

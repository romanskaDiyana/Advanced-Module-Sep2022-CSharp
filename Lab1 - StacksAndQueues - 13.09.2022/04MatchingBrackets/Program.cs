using System;
using System.Collections.Generic;

namespace _04MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04. Matching Brackets
            //We are given an arithmetic expression with brackets. Scan through the string and extract each sub-expression.
            //Print the result back at the terminal.

            string expression = Console.ReadLine();

            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    indexes.Push(i);
                }

                if (expression[i] == ')')
                {
                    int startIndex = indexes.Pop();

                    Console.WriteLine(expression.Substring(startIndex,i - startIndex + 1));
                }
            }
        }
    }
}

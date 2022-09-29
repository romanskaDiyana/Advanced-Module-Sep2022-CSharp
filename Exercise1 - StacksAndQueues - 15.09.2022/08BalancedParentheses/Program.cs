using System;
using System.Collections.Generic;
using System.Linq;

namespace _08BalancedParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //08. Balanced Parentheses
            //Given a sequence consisting of parentheses, determine whether the expression is balanced. A sequence of parentheses is balanced, if every open parenthesis can be paired uniquely with a closing parenthesis that occurs after the former. Also, the interval between them must be balanced. You will be given three types of parentheses: (, {, and [.
            //{ [()]}
            //-This is a balanced parenthesis.
            //{ [(])}
            //-This is not a balanced parenthesis.

            string parentheses = Console.ReadLine();

            Stack<char> paranthesesStack = new Stack<char>();

            IsBalanced(paranthesesStack, parentheses);
        }

        static void IsBalanced(Stack<char> paranthesesStack, string parentheses)
        {
            foreach (char currentChar in parentheses)
            {
                if (paranthesesStack.Count > 0)
                {
                    char nextChar = paranthesesStack.Peek();

                    if (nextChar == '{' && currentChar == '}')
                    {
                        paranthesesStack.Pop();
                        continue;
                    }
                    if (nextChar == '[' && currentChar == ']')
                    {
                        paranthesesStack.Pop();
                        continue;
                    }
                    if (nextChar == '(' && currentChar == ')')
                    {
                        paranthesesStack.Pop();
                        continue;
                    }
                }

                paranthesesStack.Push(currentChar);
            }

            if (paranthesesStack.Count > 0) Console.WriteLine("NO");
            else Console.WriteLine("YES");
        }
    }
}

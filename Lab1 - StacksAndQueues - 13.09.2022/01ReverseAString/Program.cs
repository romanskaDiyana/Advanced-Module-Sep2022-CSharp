using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _01ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01. Reverse String
            //Create a program that:
            //• Reads an input string
            //• Reverses it backwards(letter by latter, from the last to the first) using a Stack< T >
            //• Prints the result back at the console;

            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (var character in input)
            {
                stack.Push(character);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _09SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //09. Simple Text Editor
            //You are given an empty text. Your task is to implement 4 commands related to manipulating the text
            //• 1 someString - appends someString to the end of the text.
            //    • 2 count - erases the last count elements from the text.
            //    • 3 index - returns the element at position index from the text.
            //    • 4 - undoes the last not undone command of type 1 or 2 and returns the text to the state before that operation.

            StringBuilder text = new StringBuilder();
            Stack<string> memory = new Stack<string>();
            memory.Push(String.Empty);

            int numberOfOperations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] cmdArguments = Console.ReadLine().Split();

                string cmdType = cmdArguments[0];

                if (cmdType == "1")
                {
                    string cmdInfo = cmdArguments[1];
                    text.Append(cmdInfo);
                    memory.Push(text.ToString());
                }
                else if (cmdType == "2")
                {
                    int charToRemove = int.Parse(cmdArguments[1]);
                    text = text.Remove(text.Length - charToRemove, charToRemove);

                    memory.Push(text.ToString());
                    //string newText = text.ToString().Substring(0, text.Length - charToRemove);
                    //text = new StringBuilder(newText);
                }
                else if (cmdType == "3")
                {
                    int position = int.Parse(cmdArguments[1]);
                    if (position >= 1 && position <= text.Length)
                    {
                        Console.WriteLine(text[position-1]);
                    }
                }
                else if (cmdType == "4")
                {
                    memory.Pop();
                    string previousVersion = memory.Peek();

                    text = new StringBuilder(previousVersion);
                }
            }
        }
    }
}

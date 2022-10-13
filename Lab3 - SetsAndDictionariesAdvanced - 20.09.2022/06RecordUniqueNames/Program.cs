using System;
using System.Collections.Generic;

namespace _06RecordUniqueNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //06. Record Unique Names
            //Create a program, which will take a list of names and print only the unique names in the list.

            int numberOfNames = int.Parse(Console.ReadLine());

            HashSet<string> uniqueNames = new HashSet<string>();

            for (int i = 0; i < numberOfNames; i++)
            {
                string currentName = Console.ReadLine();
                uniqueNames.Add(currentName);
            }

            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}

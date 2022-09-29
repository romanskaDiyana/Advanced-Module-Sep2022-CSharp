using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _06Jagged_ArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //06. Jagged - Array Modification
            //Create a program that reads a matrix from the console. On the first line, you will get matrix rows. On the next rows lines, you will get elements for each column separated with space. You will be receiving commands in the following format:
            //• Add { row}
            //{ col}
            //{ value} – Increase the number at the given coordinates with the value.
            //    • Subtract { row}
            //{ col}
            //{ value} – Decrease the number at the given coordinates by the value.
            //    Coordinates might be invalid. In this case, you should print "Invalid coordinates".When you receive "END" you should print the matrix and stop the program.

            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];
            
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] splitted = command.Split();

                int row = int.Parse(splitted[1]);
                int column = int.Parse(splitted[2]);
                int value = int.Parse(splitted[3]);

                if (row >= 0 && row < jaggedArray.Length && column >= 0 && column < jaggedArray[row].Length) 
                {
                    if (splitted[0] == "add")
                    {
                        jaggedArray[row][column] += value;
                    }
                    else
                    {
                        jaggedArray[row][column] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                command = Console.ReadLine().ToLower();
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int column = 0; column < jaggedArray[row].Length; column++)
                {
                    Console.Write($"{jaggedArray[row][column]} ");
                }

                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Linq;

namespace _06JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //06. Jagged Array Manipulator
            //Create a program that populates, analyzes and manipulates the elements of a matrix with an unequal length of its rows.
            //First, you will receive an integer N equal to the number of rows in your matrix.
            //    On the next N lines, you will receive sequences of integers, separated by a single space. Each sequence is a row in the matrix.
            //    After populating the matrix, start analyzing it. If a row and the one below it have equal length, multiply each element in both of them by 2, otherwise - divide by 2.
            //    Then, you will receive commands. There are three possible commands:
            //    • "Add {row} {column} {value}" - add { value}
            //to the element at the given indexes, if they are valid.
            //    • "Subtract {row} {column} {value}" - subtract { value}
            //from the element at the given indexes, if they are valid.
            //    • "End" - print the final state of the matrix(all elements separated by a single space) and stop the program.

            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[rows][];

            JaggedArrayColumnInfo(jaggedArray,rows);

            JaggedMultiplyAndDivide(jaggedArray);

            JaggedAddAndSubtract(jaggedArray);

            PrintJaggedArray(jaggedArray, rows);
        }
        
        static void JaggedArrayColumnInfo(double[][] jaggedArray, int rows)
        {
            for (int row = 0; row < rows; row++)
            {
                double[] columnInfo = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

                jaggedArray[row] = columnInfo;
            }
        }

        static void JaggedMultiplyAndDivide(double[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int column = 0; column < jaggedArray[row].Length; column++)
                    {
                        jaggedArray[row][column] *= 2;
                        jaggedArray[row + 1][column] *= 2;
                    }
                }
                else
                {
                    for (int column = 0; column < jaggedArray[row].Length; column++)
                    {
                        jaggedArray[row][column] /= 2;
                    }

                    for (int column = 0; column < jaggedArray[row + 1].Length; column++)
                    {
                        jaggedArray[row + 1][column] /= 2;
                    }
                }
            }
        }

        static void JaggedAddAndSubtract(double[][] jaggedArray)
        {
            string command = Console.ReadLine().ToLower();

            while (true)
            {
                if (command == "end")
                {
                    break;
                }

                string[] cmdInfo = command.Split(" ");

                int row = int.Parse(cmdInfo[1]);
                int column = int.Parse(cmdInfo[2]);
                double value = double.Parse(cmdInfo[3]);

                if (row >= 0 && row < jaggedArray.Length && column >= 0 && column < jaggedArray[row].Length)
                {
                    if (cmdInfo[0] == "add")
                    {
                        jaggedArray[row][column] += value;
                    }
                    else
                    {
                        jaggedArray[row][column] -= value;
                    }
                }

                command = Console.ReadLine().ToLower();
            }
        }

        static void PrintJaggedArray(double[][] jaggedArray, int rows)
        {
            for (int row = 0; row < rows; row++)
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

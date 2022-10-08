using System;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Reflection.Metadata.Ecma335;

namespace _04MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04. Matrix Shuffling
            //Write a program that reads a string matrix from the console and performs certain operations with its elements.
            //User input is provided in a similar way as in the problems above – first, you read the dimensions and then the data. 
            ////Your program should then receive commands in the format: "swap row1 col1 row2 col2" where row1, col1, row2, col2 are coordinate
            /// s in the matrix. For a command to be valid, it should start with the "swap" keyword along with four valid coordinates
            /// (no more, no less). You should swap the values at the given coordinates(cell[row1, col1] with cell[row2, col2])
            /// and print the matrix at each step(thus you'll be able to check if the operation was performed correctly). 
            ////If the command is not valid(doesn't contain the keyword "swap", has fewer or more coordinates entered or the given
            /// coordinates do not exist), print "Invalid input!" and move on to the next command. Your program
            /// should finish when the string "END" is entered.


            string[] sizeOfTheMatrix = Console.ReadLine().Split(" ");

            int rows = int.Parse(sizeOfTheMatrix[0]);
            int columns = int.Parse(sizeOfTheMatrix[1]);

            string[,] matrix = new string[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                string[] matrixData = Console.ReadLine().Split(" ");

                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = matrixData[column];
                }
            }

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] splittedCmd = command.Split(" ");

                if (IsCommandValid(splittedCmd, rows, columns))
                {
                    int rowElToSwap = int.Parse(splittedCmd[1]);
                    int colElToSwap = int.Parse(splittedCmd[2]);

                    int rowElToSwapWith = int.Parse(splittedCmd[3]);
                    int colElToSwapWith = int.Parse(splittedCmd[4]);

                    string swappedElement = matrix[rowElToSwap, colElToSwap];
                    matrix[rowElToSwap, colElToSwap] = matrix[rowElToSwapWith, colElToSwapWith];
                    matrix[rowElToSwapWith, colElToSwapWith] = swappedElement.ToString();

                    PrintMatrix(matrix, rows, columns);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().ToLower();
            }
        }

        static void PrintMatrix(string[,] matrix, int rows, int columns)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    Console.Write($"{matrix[row, column]} ");
                }

                Console.WriteLine();
            }
        }

        static bool IsCommandValid(string[] splittedCmd, int rows, int columns)
        {
            return splittedCmd[0] == "swap"
                                  && splittedCmd.Length == 5
                                  && int.Parse(splittedCmd[1]) >= 0 && int.Parse(splittedCmd[1]) < rows
                                  && int.Parse(splittedCmd[2]) >= 0 && int.Parse(splittedCmd[2]) < columns
                                  && int.Parse(splittedCmd[3]) >= 0 && int.Parse(splittedCmd[3]) < rows
                                  && int.Parse(splittedCmd[4]) >= 0 && int.Parse(splittedCmd[4]) < columns;
        }
    }
}
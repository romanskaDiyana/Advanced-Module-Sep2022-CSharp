using System;
using System.Runtime.CompilerServices;

namespace _04SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04. Symbol in Matrix
            //Create a program that reads N, a number representing rows and cols of a matrix.
            //On the next N lines, you will receive rows of the matrix. Each row consists of
            //ASCII characters. After that, you will receive a symbol.
            //Find the first occurrence of that symbol in the matrix and print
            //its position in the format: "({row}, {col})". If there is no such
            //symbol, print an error message "{symbol} does not occur in the matrix".

            int sizeOfTheSquareMatrix = int.Parse(Console.ReadLine());

            int rows = sizeOfTheSquareMatrix;
            int columns = sizeOfTheSquareMatrix;

            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                char[] columnInfo = Console.ReadLine().ToCharArray();

                for (int column = 0; column < columns; column++)
                {
                   matrix[row, column] = columnInfo[column];
                }
            }

            char charLookingFor = char.Parse(Console.ReadLine());
            int numberInASCCI = charLookingFor;

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {

                    if (numberInASCCI == matrix[row,column])
                    {
                        Console.WriteLine($"{(row, column)}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{charLookingFor} does not occur in the matrix");
        }
    }
}

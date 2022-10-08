using System;
using System.Dynamic;

namespace _01DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01. Diagonal Difference
            //Create a program that finds the difference
            //between the sums of the square matrix diagonals (absolute value).

            int sizeOfTheSquareMatrix = int.Parse(Console.ReadLine());

            int rows = sizeOfTheSquareMatrix;
            int columns = sizeOfTheSquareMatrix;

            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                string[] columnInfo = Console.ReadLine().Split(" ");

                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = int.Parse(columnInfo[column]);
                }
            }

            DiagonalDifference(matrix);
        }

        static void DiagonalDifference(int[,] matrix)
        {
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            int diagonalsDifference = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primaryDiagonal += matrix[i, i];
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                secondaryDiagonal += matrix[i, matrix.GetLength(0) - i - 1];
            }

            diagonalsDifference = primaryDiagonal - secondaryDiagonal;

            Console.WriteLine(Math.Abs(diagonalsDifference));
        }
    }
}

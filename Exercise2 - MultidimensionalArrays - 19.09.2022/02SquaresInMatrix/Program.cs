using System;
using System.Runtime.CompilerServices;

namespace _02SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02.Squares in Matrix
            //Find the count of 2 x 2 squares of equal chars in a matrix.

            int subMatrixRow = 2;
            int subMatrixColumn = 2;

            string[] sizeOfMatrix = Console.ReadLine().Split(" ");
            int rows = int.Parse(sizeOfMatrix[0]);
            int columns = int.Parse(sizeOfMatrix[1]);

            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                string[] columnInfo = Console.ReadLine().Split(" ");

                for (int column = 0; column < columns; column++)
                {
                    char currentChar = char.Parse(columnInfo[column]);
                    matrix[row, column] = currentChar;
                }
            }

            CountOfEqualSquareElements(subMatrixRow, subMatrixColumn, matrix, rows, columns);

        }

        static void CountOfEqualSquareElements(int subMatrixRow, int subMatrixColumn, int[,] matrix, int rows, int columns)
        {

            int squareCounter = 0;
            for (int row = 0; row < rows - subMatrixRow + 1; row++)
            {
                for (int column = 0; column < columns - subMatrixColumn + 1; column++)
                {
                    if (matrix[row, column] == matrix[row + 1, column] &&
                        matrix[row, column] == matrix[row, column + 1] &&
                        matrix[row, column] == matrix[row + 1, column + 1])
                    {
                        squareCounter++;
                    }
                }
            }

            Console.WriteLine(squareCounter);
        }
    }
}

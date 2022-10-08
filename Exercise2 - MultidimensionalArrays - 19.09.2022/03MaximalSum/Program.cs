using System;

namespace _03MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03. Maximal Sum
            //Create a program that reads a rectangular integer matrix
            //of size N x M and finds in it the square 3 x 3 that has a maximal sum of its elements.

            int subMatrixRow = 3;
            int subMatrixColumn = 3;

            string[] sizeOfMatrix = Console.ReadLine().Split(" ");
            int rows = int.Parse(sizeOfMatrix[0]);
            int columns = int.Parse(sizeOfMatrix[1]);

            int[,] matrix = new int[rows, columns];

            MatrixInfo(matrix, rows, columns);

            MaxSquareSumAndPrint(subMatrixRow, subMatrixColumn, matrix, rows, columns);

        }

        static void MaxSquareSumAndPrint(int subMatrixRow, int subMatrixColumn, int[,] matrix, int rows, int columns)
        {
            int maxSquareSum = 0;
            int squareStartRow = 0;
            int squareStartColumn = 0;
            for (int row = 0; row < rows - subMatrixRow + 1; row++)
            {
                for (int column = 0; column < columns - subMatrixColumn + 1; column++)
                {
                    int currentSquareSum = 0;

                    for (int subRow = 0; subRow < subMatrixRow; subRow++)
                    {
                        for (int subColumn = 0; subColumn < subMatrixColumn; subColumn++)
                        {
                            currentSquareSum += matrix[row + subRow, column + subColumn];
                        }
                    }

                    if (currentSquareSum > maxSquareSum)
                    {
                        maxSquareSum = currentSquareSum;
                        squareStartRow = row;
                        squareStartColumn = column;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSquareSum}");

            for (int subRow = 0; subRow < subMatrixRow; subRow++)
            {
                for (int subColumn = 0; subColumn < subMatrixColumn; subColumn++)
                {
                    Console.Write($"{matrix[squareStartRow + subRow, squareStartColumn + subColumn]} ");
                }

                Console.WriteLine();
            }
        }

        static void MatrixInfo(int[,] matrix, int rows, int columns)
        {
            for (int row = 0; row < rows; row++)
            {
                string[] columnInfo = Console.ReadLine().Split(" ");

                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = int.Parse(columnInfo[column]);
                }
            }
        }
    }
}

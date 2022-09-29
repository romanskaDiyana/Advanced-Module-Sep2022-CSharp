using System;

namespace _05SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Square With Maximum Sum
            //Create a program that reads a matrix from the console. Then find the biggest sum of the 2x2 submatrix and print it to the console.
            //On the first line, you will get matrix sizes in format rows, columns.
            //On the next rows lines, you will get elements for each column, separated with a comma and a space.
            //    Print the biggest top - left square, which you find, and the sum of its elements.
            
            int subMatrixRow = 2;
            int subMatrixColumn = 2;

            string[] sizeOfMatrix = Console.ReadLine().Split(", ");
            int rows = int.Parse(sizeOfMatrix[0]);
            int columns = int.Parse(sizeOfMatrix[1]);

            int[,] matrix = new int[rows, columns];

            MatrixInfo(matrix,rows,columns);

            MaxSquareSumAndPrint(subMatrixRow,subMatrixColumn,matrix,rows,columns);

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
                    currentSquareSum += matrix[row, column];
                    currentSquareSum += matrix[row + 1, column];
                    currentSquareSum += matrix[row, column + 1];
                    currentSquareSum += matrix[row + 1, column + 1];

                    if (currentSquareSum > maxSquareSum)
                    {
                        maxSquareSum = currentSquareSum;
                        squareStartRow = row;
                        squareStartColumn = column;
                    }
                }
            }

            Console.WriteLine(
                $"{matrix[squareStartRow, squareStartColumn]} {matrix[squareStartRow, squareStartColumn + 1]}");

            Console.WriteLine(
                $"{matrix[squareStartRow + 1, squareStartColumn]} {matrix[squareStartRow + 1, squareStartColumn + 1]}");

            Console.WriteLine(maxSquareSum);
        }

        static void MatrixInfo(int[,] matrix, int rows, int columns)
        {
            for (int row = 0; row < rows; row++)
            {
                string[] columnInfo = Console.ReadLine().Split(", ");

                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = int.Parse(columnInfo[column]);
                }
            }
        }
    }
}
    

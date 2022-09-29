using System;
using System.Dynamic;
using System.Linq;

namespace _01SumMatrixElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01. Sum Matrix Elements
            //Write a program that reads a matrix from the console and prints:
            //    • Count of rows
            //    • Count of columns
            //    • Sum of all matrix elements
            //    On the first line, you will get matrix sizes in format[rows, columns]


            int[] sizeOfMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = sizeOfMatrix[0];
            int columns = sizeOfMatrix[1];
            int intSumOfMatrix = 0;

            int[,] matrix = new int[rows, columns];
            //int[,] matrix = new int[sizeOfMatrix[0], sizeOfMatrix[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowInfo = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int column = 0; column < rowInfo.Length; column++)
                {
                    matrix[row, column] = rowInfo[column];
                }
            }

            PrintMatrix(matrix,intSumOfMatrix,rows,columns);
        }
        
        static void PrintMatrix(int[,] matrix, int intSumOfMatrix, int rows, int columns)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    intSumOfMatrix += matrix[row, col];
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(intSumOfMatrix);
        }
    }
}

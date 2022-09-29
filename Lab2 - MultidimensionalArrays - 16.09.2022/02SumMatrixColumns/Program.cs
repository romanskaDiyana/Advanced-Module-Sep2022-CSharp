
using System;
using System.Data;
using System.Linq;

namespace _02SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02. Sum Matrix Columns
            //Create a program that reads a matrix from the console and prints the sum for each column.
            //On the first line, you will get matrix rows. On the next rows lines, you will get elements
            //for each column separated with a space. 

            string[] sizeOfMatrix = Console.ReadLine().Split(", ");

            int rows = int.Parse(sizeOfMatrix[0]);
            int columns = int.Parse(sizeOfMatrix[1]);

            int[,] matrix = new int[rows, columns];
            
            for (int row = 0; row < rows; row++)
            {
                string[] columnInfo = Console.ReadLine().Split(" ");

                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = int.Parse(columnInfo[column]);
                }
            }

            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                int sumOfColumns = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumOfColumns += matrix[row, column];
                }

                Console.WriteLine(sumOfColumns);
            }
        }
    }
}

using System;

namespace _03PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03. Primary Diagonal
            //Create a program that finds the sum of elements from the matrix’s primary diagonal.

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

            SumPrimaryDiagonal(matrix);
        }
        
        static void SumPrimaryDiagonal(int[,] matrix)
        {
            int sumOfPrimaryDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumOfPrimaryDiagonal+=matrix[i, i];
            }

            Console.WriteLine(sumOfPrimaryDiagonal);
        }
    }
}

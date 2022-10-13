using System;
using System.Data;

namespace _06EightQueensProblem_BackTrack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Матрица, която принтира всички възможни конфигурации на царици, в които конфигурации няма конфликт помежду им;

            int numberOfQConfigOptions = 8;

            int[,] matrix = new int[numberOfQConfigOptions, numberOfQConfigOptions];
            Console.WriteLine(GetQueens(matrix, 0));
        }

        static void PrintQueens(int[,] queens)
        {
            for (int row = 0; row < queens.GetLength(0); row++)
            {
                for (int column = 0; column < queens.GetLength(1); column++)
                {
                    if (queens[row,column] == 1)
                    {
                        Console.Write("|Q|");
                    }
                    if (queens[row,column] == 0)
                    {
                        Console.Write("|_|");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static int GetQueens(int[,] queens, int row)
        {
            if (row == queens.GetLength(0))
            {
                PrintQueens(queens);
                return 1;
            }

            int foundQueens = 0;

            for (int column = 0; column < queens.GetLength(1); column++)
            {
                if (IsSafe(queens,row,column))
                {
                    queens[row, column] = 1;
                    foundQueens += GetQueens(queens, row + 1);
                    queens[row, column] = 0; //при референтни типове, винаги трябва да се "зачиства";
                }
            }

            return foundQueens;
        }
        
        static bool IsSafe(int[,] queens, int row, int column)
        {
            for (int i = 1; i < queens.GetLength(0); i++)
            {
                if (row - i >= 0 && queens[row - i, column] == 1)
                {
                    return false;
                }
                if (column - i >= 0 && queens[row, column - i] == 1)
                {
                    return false;
                }
                if (row + i < queens.GetLength(0) && queens[row + i, column] == 1)
                {
                    return false;
                }
                if (column + i < queens.GetLength(0) && queens[row, column + i] == 1)
                {
                    return false;
                }

                //диагонали;

                if (column + i < queens.GetLength(0) &&
                    row + i < queens.GetLength(0) && 
                    queens[row + i, column + i] == 1)
                {
                    return false;
                }

                if (column - i >= 0 &&
                    row + i < queens.GetLength(0) &&
                    queens[row + i, column - i] == 1)
                {
                    return false;
                }

                if (row - i >= 0 &&
                    column - i >= 0 &&
                    queens[row - i, column - i] == 1)
                {
                    return false;
                }

                if (column + i < queens.GetLength(0) &&
                    row - i >= 0 &&
                    queens[row - i, column + i] == 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

using System;

namespace _07KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //07. Knight Game

            //Chess is the oldest game, but it is still popular these days. For this task we will use only one chess piece – the Knight. 
            //The knight moves to the nearest square, but not on the same row, column or diagonal. (This can be thought of as moving two squares horizontally, then one square vertically, or moving one square horizontally, then two squares vertically— i.e. in an "L" pattern.) 
            //The knight game is played on a board with dimensions N x N and a lot of chess knights 0 <= K <= N2.
            //    You will receive a board with K for knights and '0' for empty cells. Your task is to remove a minimum of the knights, so there will be no knights left that can attack another knight.

            int sidesOfTheBoard = int.Parse(Console.ReadLine());

            if (sidesOfTheBoard < 3)
            {
                Console.WriteLine(0);

                return;
            }

            char[,] matrix = new char[sidesOfTheBoard, sidesOfTheBoard];

            for (int row = 0; row < sidesOfTheBoard; row++)
            {
                string chessChars = Console.ReadLine();

                for (int column = 0; column < sidesOfTheBoard; column++)
                {
                    matrix[row, column] = chessChars[column];
                }
            }

            int knightsRemoved = 0;

            while (true)
            {
                int counterMostAttacked = 0;
                int rowMostAttacked = 0;
                int columnMostAttack = 0;

                for (int row = 0; row < sidesOfTheBoard; row++)
                {
                    for (int column = 0; column < sidesOfTheBoard; column++)
                    {
                        if (matrix[row, column] == 'K')
                        {
                            int attackedKnights = CountAttackedKnights(row, column, sidesOfTheBoard, matrix);

                            if (counterMostAttacked < attackedKnights)
                            {
                                counterMostAttacked = attackedKnights;
                                rowMostAttacked = row;
                                columnMostAttack = column;
                            }
                        }
                    }
                }

                if (counterMostAttacked == 0) break;
                else
                {
                    matrix[rowMostAttacked, columnMostAttack] = '0';
                    knightsRemoved++;
                }
            }

            Console.WriteLine(knightsRemoved);
        }

        static int CountAttackedKnights(int row, int column, int sidesOfTheBoard, char[,] matrix)
        {
            int attackedKnights = 0;

            if (IsCellValid(row - 1, column - 2, sidesOfTheBoard))
            {
                if (matrix[row - 1, column - 2] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsCellValid(row + 1, column - 2, sidesOfTheBoard))
            {
                if (matrix[row + 1, column - 2] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsCellValid(row - 1, column + 2, sidesOfTheBoard))
            {
                if (matrix[row - 1, column + 2] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsCellValid(row + 1, column + 2, sidesOfTheBoard))
            {
                if (matrix[row + 1, column + 2] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsCellValid(row - 2, column - 1, sidesOfTheBoard))
            {
                if (matrix[row - 2, column - 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsCellValid(row - 2, column + 1, sidesOfTheBoard))
            {
                if (matrix[row - 2, column + 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsCellValid(row + 2, column - 1, sidesOfTheBoard))
            {
                if (matrix[row + 2, column - 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsCellValid(row + 2, column + 1, sidesOfTheBoard))
            {
                if (matrix[row + 2, column + 1] == 'K')
                {
                    attackedKnights++;
                }
            }

            return attackedKnights;
        }

        static bool IsCellValid(int row, int column, int sidesOfTheBoard)
        {
            return row >= 0 && row < sidesOfTheBoard && column >= 0 && column < sidesOfTheBoard;
        }
    }
}

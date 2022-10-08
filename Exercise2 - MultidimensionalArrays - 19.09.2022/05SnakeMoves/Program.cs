using System;
using System.Linq;

namespace _05SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05. Snake Moves
            //You are walking in the park and you encounter a snake! You are terrified and you start running zig-zag, so the snake starts following you. 
            //You have a task to visualize the snake's path in a square form. A snake is represented by a string.
            //The isle is a rectangular matrix of size N x M. A snake starts going down from the top-left corner
            //and slithers its way down. The first cell is filled with the first symbol of the snake, the second
            //cell is filled with the second symbol, etc. The snake is as long as it takes to fill the stairs–
            //if you reach the end of the string representing the snake, start again at the beginning.
            //After you fill the matrix with the snake's path, you should print it.

            int[] sizeOfTheMatrix = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int rows = sizeOfTheMatrix[0];
            int columns = sizeOfTheMatrix[1];

            char[,] matrix = new char[rows, columns];

            SnakeMoves(matrix, rows, columns);

            PrintSnakeMoves(matrix, rows, columns);

        }
        
        static void PrintSnakeMoves(char[,] matrix, int rows, int columns)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    Console.Write($"{matrix[row, column]}");
                }

                Console.WriteLine();
            }
        }

        static void SnakeMoves(char[,] matrix, int rows, int columns)
        {
            string snake = Console.ReadLine();

            int currentSnakeIndex = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int column = 0; column < columns; column++)
                    {
                        if (currentSnakeIndex == snake.Length)
                        {
                            currentSnakeIndex = 0;
                        }
                        matrix[row, column] = snake[currentSnakeIndex];
                        currentSnakeIndex++;
                    }
                }
                else
                {
                    for (int column = columns - 1; column >= 0; column--)
                    {
                        if (currentSnakeIndex == snake.Length)
                        {
                            currentSnakeIndex = 0;
                        }
                        matrix[row, column] = snake[currentSnakeIndex];
                        currentSnakeIndex++;
                    }
                }
            }
        }
    }
}

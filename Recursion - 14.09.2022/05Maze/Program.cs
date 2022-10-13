using System;

namespace _05Maze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Намиране на изход от лабиринт; - Рекурсия

            string[] maze = new[]
            {
                "010001",
                "01010E",
                "010100",
                "000000",
            };

            Console.WriteLine("Maze matrix:");
            PrintMaze(maze);

            FindPaths(maze, 0, 0, new bool[maze.Length, maze[0].Length]," ");
        }
        static void FindPaths(string[] maze, int row, int column, bool[,] visited, string path)
        {
            if (maze[row][column] == 'E')
            {
                Console.WriteLine("A path has been found!");
                Console.Write($"Follow this path trough the exit: {path}");
                Console.WriteLine("Exit!");
                return;
            }
            visited[row, column] = true;

            if (IsSafe(maze, row + 1, column, visited))
            {
                FindPaths(maze, row + 1, column, visited, path + "Down-> ");
            }

            if (IsSafe(maze, row - 1, column, visited))
            {
                FindPaths(maze, row - 1, column, visited, path + "Up-> ");
            }

            if (IsSafe(maze, row, column + 1, visited))
            {
                FindPaths(maze, row, column + 1, visited, path + "Right-> ");
            }

            if (IsSafe(maze, row, column - 1, visited))
            {
                FindPaths(maze, row, column - 1, visited, path + "Left-> ");
            }

            visited[row, column] = false;
        }

        static bool IsSafe(string[] maze, int row, int column, bool[,] visited)
        {
            if (row < 0 || column < 0 || row >= maze.Length || column>= maze[0].Length)
            {
                return false;
            }

            if (maze[row][column] == '1' || visited[row,column])
            {
                return false;
            }

            return true;
        }

        static void PrintMaze(string[] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[0].Length; column++)
                {
                    Console.Write(matrix[row][column]);
                }

                Console.WriteLine();
            }
        }
    }
}

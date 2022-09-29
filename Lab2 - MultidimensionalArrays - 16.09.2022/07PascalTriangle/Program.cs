using System;

namespace _07PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //07. Pascal Triangle
            //The Pascal’s triangle may be constructed in the following manner: in row 0 (the topmost row),
            //there is a unique nonzero entry 1. Each entry of each subsequent row is constructed by adding
            //the number above and to the left with the number above and to the right, treating blank entries as 0:

            long sizeOfTriangle = long.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[sizeOfTriangle][];
            pascalTriangle[0] = new long[1] { 1 };

            for (long row = 1; row < sizeOfTriangle; row++)
            {
                pascalTriangle[row] = new long[pascalTriangle[row - 1].Length + 1];

                for (long column = 0; column < pascalTriangle[row].Length; column++)
                {
                    if (pascalTriangle[row - 1].Length > column)
                    {
                        pascalTriangle[row][column] += pascalTriangle[row - 1][column];
                    }
                    if (column > 0)
                    {
                        pascalTriangle[row][column] += pascalTriangle[row - 1][column - 1];
                    }
                }
            }

            PrintPascalTriangle(pascalTriangle);
        }

        static void PrintPascalTriangle(long[][] jaggedArray)
        {
            for (long row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine($"{String.Join(" ", jaggedArray[row])}");
            }
        }
    }
}

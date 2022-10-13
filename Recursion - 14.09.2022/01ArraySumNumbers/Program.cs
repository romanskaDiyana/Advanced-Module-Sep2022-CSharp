using System;

namespace _01ArraySumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] { 3, 8, 9 };

            Console.WriteLine(Sum(array, 0));

            static int Sum(int[] array, int index)
            {
                if (index == array.Length)
                {
                    return 0;
                } // край на рекурсия;

                Console.WriteLine("Before entering recursive method");
                int currentSum = array[index] + Sum(array, index + 1); //index + 1 - следващия return;
                Console.WriteLine(currentSum);

                Console.WriteLine("After entering recursive method");

                return currentSum;
            }
        }
    }
}

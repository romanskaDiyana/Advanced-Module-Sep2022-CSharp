using System;

namespace Recursion___14._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print(10);
        }

        static void Print(int n)
        {
            if (n == 0)
            {
                return;
            } //"дъно" на рекурсия, край;

            Console.Write("Hello world!");
            Console.WriteLine($": {n}");

            Print(n - 1);
        }
    }
}


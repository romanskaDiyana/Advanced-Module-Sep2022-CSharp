using System;

namespace _02StackSizeAndOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackOverflow();
        }

        static unsafe void StackOverflow()
        {
            int x = 5;

            Console.WriteLine((long)&x);
            StackOverflow();
        }
    }
}

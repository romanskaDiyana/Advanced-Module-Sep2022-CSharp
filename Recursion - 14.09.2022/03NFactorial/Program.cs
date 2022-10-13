using System;

namespace _03NFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(NFactorial(n));
        }
        static int NFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            int currentFactorial = n * NFactorial(n - 1);
            return currentFactorial;
        }
    }
}

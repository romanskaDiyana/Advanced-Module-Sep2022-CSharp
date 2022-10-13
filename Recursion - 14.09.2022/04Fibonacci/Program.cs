using System;

namespace _04Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fibonacciNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(fibonacciNumber));
        }

         static int Fibonacci(int fibonacciNumber)
         {
             if (fibonacciNumber == 0)
             {
                 return 0;
             }

             if (fibonacciNumber == 0 || fibonacciNumber == 2)
             {
                 return 1;
             }
             return Fibonacci(fibonacciNumber - 1) + Fibonacci(fibonacciNumber - 2); //Рекурсията не е подходяща за решаване на Fibonacci!!
             //Подходяща за намиране на всички възможни подходи: лабиринти, шах, изкуствен интелект;
         }
    }
}

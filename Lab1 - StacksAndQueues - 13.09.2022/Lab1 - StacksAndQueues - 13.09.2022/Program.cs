using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Lab1___StacksAndQueues___13._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack vs. List Performance

            int n = 100000;

            Console.WriteLine("List performance: ");
            List<int> list = new List<int>();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < n; i++)
            {
                list.Insert(0,i);
            }

            for (int i = 0; i < n; i++)
            {
                list.RemoveAt(0);
            }
            watch.Stop();
            Console.WriteLine($"Performance in ms: {watch.ElapsedMilliseconds}ms.");

            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine();

            Console.WriteLine("Stack performance: ");
            Stack<int> stack = new Stack<int>();
            watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < n; i++)
            {
                stack.Push(i);
            }

            for (int i = 0; i < n; i++)
            {
                stack.Pop();
            }
            watch.Stop();
            Console.WriteLine($"Performance in ms: {watch.ElapsedMilliseconds}ms.");
        }
    }
}

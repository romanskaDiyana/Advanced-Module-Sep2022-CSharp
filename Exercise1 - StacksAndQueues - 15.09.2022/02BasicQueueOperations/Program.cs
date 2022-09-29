using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02. Basic Queue Operations
            //Play around with a queue. You will be given an integer N representing the number of elements to enqueue (add), an integer S, representing the number of elements to dequeue (remove) from the queue, and finally an integer X, an element that you should look for in the queue. If it is, print true on the console. If it's not printed the smallest element is currently present in the queue. If there are no elements in the sequence, print 0 on the console.

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numberOfElementsToEnqueue = numbers[0];
            int numberOfElementsToDequeue = numbers[1];
            int numberToLookFor = numbers[2];

            
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < numberOfElementsToEnqueue; i++)
            {
                queue.Enqueue(integers[i]);
            }

            for (int i = 0; i < numberOfElementsToDequeue; i++)
            {
                queue.Dequeue();
            }

            for (int i = 0; i < queue.Count; i++)
            {
                if (queue.Contains(numberToLookFor))
                {
                    Console.WriteLine("true");
                    return;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine($"{queue.Count}");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04. Fast Food
            //You have a fast-food restaurant and most of the food that you're offering is previously prepared. You need to know if you will have enough food to serve lunch to all of your customers. Write a program that checks the orders' quantity. You also want to know the client with the biggest order for the day, because you want to give him a discount the next time he comes. 
            //First, you will be given the quantity of the food that you have for the day (an integer number).  Next, you will be given a sequence of integers, each representing the quantity of order.Keep the orders in a queue.Find the biggest order and print it.You will begin servicing your clients from the first one that came.Before each order, check if you have enough food left to complete it.If you have, remove the order from the queue and reduce the amount of food you have. If you succeeded in servicing all of your clients, print:
            //"Orders complete".
            //    If not – print:
            //"Orders left: {order1} {order2} .... {orderN}".

            int quantityOfFood = int.Parse(Console.ReadLine());

            var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(orders.Max());
            int currentQuantityOfFood = quantityOfFood;

            for (int i = 0; i < orders.Length; i++)
            {
                if (currentQuantityOfFood >= orders[i])
                {
                    queue.Dequeue();
                    currentQuantityOfFood -= orders[i];
                }
                else
                {
                    Console.Write("Orders left: ");
                    Console.WriteLine(string.Join(" ", queue));
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}

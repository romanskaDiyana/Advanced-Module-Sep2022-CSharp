using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace _08TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //08. Traffic Jam
            //Create a program that simulates the queue that forms during a traffic jam. During a traffic jam, only N cars can pass the crossroads when the light goes green. Then the program reads the vehicles that arrive one by one and adds them to the queue. When the light goes green N number of cars pass the crossroads and for each, a message "{car} passed!" is displayed. When the "end" command is given, terminate the program and display a message with the total number of cars that passed the crossroads.

            int carsToPast = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            string command = Console.ReadLine();
            int passedCarsCount = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < carsToPast; i++)
                    {
                        if (cars.Count > 0)
                        {
                            string car = cars.Dequeue();

                            Console.WriteLine($"{car} passed!");
                            passedCarsCount++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{passedCarsCount} cars passed the crossroads.");
        }
    }
}

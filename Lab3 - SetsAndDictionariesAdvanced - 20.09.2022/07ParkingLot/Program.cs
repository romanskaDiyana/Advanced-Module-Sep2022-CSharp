using System;
using System.Collections.Generic;
using System.Linq;

namespace _07ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //07. Parking Lot
            //Create a program that:
            //• Records a car number for every car that enters the parking lot.
            //    • Removes a car number when the car leaves the parking lot.
            //    The input will be a string in the format: "direction, carNumber".You will be receiving commands until the "END" command is given.
            //    Print the car numbers of the cars, which are still in the parking lot:


            HashSet<string> parkingSet = new HashSet<string>();

            ParkingSetCheck(parkingSet);

            PrintParkingSet(parkingSet);
        }

        static void ParkingSetCheck(HashSet<string> parkingSet)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandInfo = command.Split(", ");
                string action = commandInfo[0];
                string carNumber = commandInfo[1];

                if (action == "IN")
                {
                    if (!parkingSet.Contains(carNumber))
                    {
                        parkingSet.Add(carNumber);
                    }
                }
                else
                {
                    parkingSet.Remove(carNumber);
                }

                command = Console.ReadLine();
            }
        }

        static void PrintParkingSet(HashSet<string> parkingSet)
        {
            if (parkingSet.Count > 0)
            {
                foreach (var carNumber in parkingSet)
                {
                    Console.WriteLine(carNumber);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}

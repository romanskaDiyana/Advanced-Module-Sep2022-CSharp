using System;
using System.Collections.Generic;

namespace _08SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //08. SoftUni Party
            //There is a party in SoftUni. Many guests are invited and there are two types of them: VIP and Regular. When a guest comes, check if he/she exists in any of the two reservation lists.
            //All reservation numbers will be with the length of 8 chars.
            //    All VIP numbers start with a digit.
            //    First, you will be receiving the reservation numbers of the guests. You can also receive 2 possible commands:
            //    • "PARTY" – After this command, you will begin receiving the reservation numbers of the people, who came to the party.
            //    • "END" – The party is over and you have to stop the program and print the appropriate output.
            //    In the end, print the count of the guests who didn't come to the party, and afterward, print their reservation numbers. the VIP guests must be first.

            HashSet<string> reservationSet = new HashSet<string>();
            HashSet<string> guestSet = new HashSet<string>();

            ReservationsInformation(reservationSet);

            StartTheParty(reservationSet, guestSet);
        }

        static void ReservationsInformation(HashSet<string> reservationSet)
        {
            string reservationsInfo = Console.ReadLine();

            while (reservationsInfo.Length == 8)
            {
                reservationSet.Add(reservationsInfo);
                reservationsInfo = Console.ReadLine();
            }
        }

        static void StartTheParty(HashSet<string> reservationSet, HashSet<string> guestSet)
        {
            string guestWhoCame = Console.ReadLine();

            while (true)
            {
                if (guestWhoCame == "END") EndOfTheParty(reservationSet);

                if (reservationSet.Contains(guestWhoCame))
                {
                    guestSet.Add(guestWhoCame);
                    reservationSet.Remove(guestWhoCame);
                }

                guestWhoCame = Console.ReadLine();
            }
        }

        static void EndOfTheParty(HashSet<string> reservationSet)
        {
            Console.WriteLine(reservationSet.Count);

            foreach (var guest in reservationSet)
            {
                if (char.IsNumber(guest[0])) Console.WriteLine(guest);
            }

            foreach (var guest in reservationSet)
            {
                if (!char.IsNumber(guest[0])) Console.WriteLine(guest);
            }

            return;
        }
    }
}

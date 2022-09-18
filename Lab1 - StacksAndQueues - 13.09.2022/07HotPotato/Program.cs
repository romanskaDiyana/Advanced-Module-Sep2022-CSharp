using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace _07HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //07.Hot Potato
            //Hot potato is a game in which children form a circle and start passing a hot potato. The counting starts with the first kid. Every nth toss the child left with the potato leaves the game. When a kid leaves the game, it passes the potato along to its next neighbor. This continues until there is only one kid left.

            string[] kids = Console.ReadLine().Split();
            int hotPotato = int.Parse(Console.ReadLine());

            Queue<string> kidsQueue = new Queue<string>(kids);
            int torsess = 1;

            while (kidsQueue.Count > 1)
            {
                string currentKid = kidsQueue.Dequeue();

                if (torsess == hotPotato)
                {
                    Console.WriteLine($"Removed {currentKid}");
                    torsess = 1;
                    continue;
                }

                torsess++;
                kidsQueue.Enqueue(currentKid);
            }

            Console.WriteLine($"Last is {kidsQueue.Dequeue()}");
        }
    }
}

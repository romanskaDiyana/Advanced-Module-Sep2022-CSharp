using System;
using System.Collections.Generic;
using System.Linq;

namespace _06SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //06. Songs Queue
            //Write a program that keeps track of a song's queue. The first song that is put in the queue, should be the first that gets played. A song cannot be added, if it is currently in the queue.
            //You will be given a sequence of songs, separated by a comma and a single space.After that, you will be given commands until there are no songs enqueued. When there are no more songs in the queue print "No more songs!" and stop the program.
            //    The possible commands are:
            //    • "Play" - plays a song(removes it from the queue)
            //    • "Add {song}" - adds the song to the queue, if it isn't contained already, otherwise print "{song} is already contained!"
            //    • "Show" - prints all songs in the queue, separated by a comma and a white space(start from the first song in the queue to the last)

            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> songQueue = new Queue<string>(songs);

            while (songQueue.Count > 0)
            {
                string input = Console.ReadLine();

                if (input == "Play")
                {
                    songQueue.Dequeue();
                }
                else if (input == "Show")
                {
                    Console.WriteLine(string.Join(", ", songQueue));
                }
                else
                {
                    string songToAdd = string.Join(" ", input.Split().Skip(1));

                    if (songQueue.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!"); 
                    }
                    else
                    {
                        songQueue.Enqueue(songToAdd);
                    }
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}

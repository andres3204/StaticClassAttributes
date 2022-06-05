using System;

namespace StaticClassAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song lucidDreams = new Song(" Lucid Dreams", " Juice World", 500);
            Console.WriteLine(Song.songCount);
            Song lonely = new Song(" Lonely", " Justin Bieber", 300);
            Console.WriteLine(lonely.GetSongCount());

            Console.ReadLine();
        }
    }
}
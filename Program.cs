using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a List, named goodSongs, that will hold tuples consisting of two strings.
            //var product = Tuple.Create("Yo-yo", 1, 9.04);
            //Console.WriteLine($"{product.Item1} {product.Item2} {product.Item3} ");
            List<(string, string)> GoodSongs = new List<(string, string)>();

            //// Define a HashSet, named allSongs, that contains 7 tuples. Each tuple should contain two string values:
            HashSet<(string artist, string song)> allSongs = new HashSet<(string artist, string song)>()
        // The name of an artist
        // A song by that artist
        {
            ("Nickelback", "Far Away"),
            ("Nickelback", "Rockstar"),
            ("Nickelback", "Photograph"),
            ("Nickelback", "Someday"),
            ("The Beatles", "She Loves You"),
            ("Nickelback", "Savin Me"),
            ("The Cure", "Pictures Of You"),
        };

            // Once the set is populated with 7 tuples, iterate over the set of songs,

            foreach ((string artist, string song) song in allSongs)
            {
                //check if the band name is "Nickelback".
                if (song.artist != "Nickelback")
                {
                    // If the band is not Nickelback, then add it to the goodSongs list.
                    GoodSongs.Add(song);
                }
            }

            // Use another foreach loop to print out all the good songs.
            foreach ((string artist, string song) song in GoodSongs)
            {
                {
                    // print out all the good songs.
                    System.Console.WriteLine(song);

                }
            }

        }
    }
}






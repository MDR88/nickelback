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
           HashSet<(string artist, string song)> allSongs = new HashSet<(string, string)>()
        // The name of an artist
        // A song by that artist
        {
            ("Nickelback", "Far Away"),
            ("Nickelback", "Rockstar"),
            ("Nickelback", "Photograph"),
            ("Nickelback", "Someday"),
            ("Nickelback", "Burn It To The Ground"),
            ("Nickelback", "Savin Me"),
            ("Nickelback", "If Today Was Your Last Day"),





        };


        }
    }
}


// Instructions
// Define a List, named goodSongs, that will hold tuples consisting of two strings.

// Define a HashSet, named allSongs, that contains 7 tuples. Each tuple should contain two string values:


// // Example
// HashSet<(string, string)> songs = new HashSet<(string, string)>();
// Make sure that some of the songs are from the band Nickelback. You can see a list of their greatest hits on Amazon.

// Once the set is populated with 7 tuples, iterate over the set of songs, and check if the band name is "Nickelback".

// If the band is not Nickelback, then add it to the goodSongs list.

// USe another foreach loop to print out all the good songs.
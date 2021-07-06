using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQexercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string> { "God of War", "Halo", "Sea of Thieves", "Pokemon", "Apex Legends", "League of Legends" };
            var LengthNames = videoGames.Where(name => name.Length > 1).OrderByDescending(name => name.Length);
            foreach(var name in LengthNames)
            {
                Console.WriteLine(name);
            }



        }
    }
}

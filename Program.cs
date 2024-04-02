﻿using NarrativeProject.Rooms;
using System;

namespace NarrativeProject
{
     //Basic idea: Make an MOTHER/EarthBound Beginnings inspired text-based game.
    
    internal class Program
    {
        static void Main(string[] args)
        {

          
            var game = new Game(42);



            game.Add(new Bedroom());
            game.Add(new Bathroom());
            game.Add(new AtticRoom());
            game.Add(new LivingRoom());

            while (!game.IsGameOver())
            {
                Console.WriteLine("—————————————————————————————————————————————————————");
                Console.WriteLine(game.CurrentRoomDescription);
                string choice = Console.ReadLine().ToLower() ?? "";
                Console.Clear();
                game.ReceiveChoice(choice);
            }

            Console.WriteLine("THE END");
            Console.ReadLine();
        }
    }
}

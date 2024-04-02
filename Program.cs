using NarrativeProject.Rooms;
using System;

namespace NarrativeProject
{
    //Basic idea: Make an MOTHER/EarthBound Beginnings inspired text-based game.
    //Take place in one of the locations from the game (maybe)
    //Items: Mostly stuff to recover HP, open doors or Gift Boxes and other items to help escape the building.
    //Make new rooms, remove the old ones

    /*
     Room ideas: Main Lobby (starting point), Kitchen, Basement, Attic, Garden/Backyard, 
     Front yard + gates(EXIT/Last Room), 2 Bedrooms (1 kids + 1 adults), 2 Bathrooms (1 Downtsairs + 1 Upstairs)
    */
    
    /*
       Enemy ideas: Zombies, Ghosts, Bats, Ghost Armor, Bloody Zombie (Last Boss)
    */
    internal class Program
    {
        static void Main(string[] args)
        {

          
            var game = new Game(42);



            game.Add(new MainLobby());
            game.Add(new DownstairsBathroom());
            game.Add(new SecondFloor());
            game.Add(new FrontYard());
            game.Add(new Kitchen());

            while (!game.IsGameOver())
            {
                Console.WriteLine("—————————————————————————————————————————————————————");
                Console.WriteLine(game.CurrentRoomDescription);
                string choice = Console.ReadLine().ToLower() ?? "";
                Console.Clear();
                game.ReceiveChoice(choice);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("YOU WON!");
            Console.ReadLine();
            Console.ResetColor();
        }
    }
}

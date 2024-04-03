using System;

namespace NarrativeProject.Rooms
{
    internal class Bathroom : Room
    {
        internal override string CreateDescription() =>
@"The bathroom has a nice calming vibe.

The [bathtub] is filled with hot water.
The [mirror] in front of you shows your reflection.
You can return to the [main lobby].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bathtub":                    
                    Console.WriteLine("You relax in the bath. ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your HP completely recovered!");
                    Console.ResetColor();

                    //Code that restores the players HP to 100%
                    break;
                case "mirror":
                        Console.WriteLine("It's you, [Ninten]!");
                    //Show the players name
                    break;
                case "main lobby":
                    Console.WriteLine("You return to the Main Lobby.");
                    Game.Transition<MainLobby>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}

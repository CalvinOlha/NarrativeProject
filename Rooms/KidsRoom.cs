using NarrativeProject.Rooms;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NarrativeProject
{
    internal class KidsRoom : Room
    {
        internal static bool isBaseKeyCollected;
        internal override string CreateDescription() =>
@"You are in the kids room.

You see a [closet] next to you.
Behind you is the door back to the [hallway].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "closet":
                    Console.WriteLine($"You look inside the closet. \n You see a Basement Key in the closet.");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"You got the Basement Key!");
                    isBaseKeyCollected = true;
                    Console.ResetColor();

                    break;
                case "hallway":
                    Console.WriteLine("You go back to the second floor hallway.");
                    Game.Transition<SecondFloor>();
                    break;
                case "map":
                    System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "Images\\ローズマリーさんのやしき.png", UseShellExecute = true });
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
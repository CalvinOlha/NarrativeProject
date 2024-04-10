using NarrativeProject.Rooms;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NarrativeProject
{
    internal class Garden : Room
    {
        internal override string CreateDescription() =>
@"You are in the kitchen, the smell of old rotting food fills the air...

You see some [drawers] next to you.
You see some [cupboards] above you.
Behind you is the door back to the [main lobby].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "drawers":
                    Console.WriteLine("all the blades of the knives look blunt...");
                    break;
                case "cupboards":
                    Console.WriteLine("all the food is dusty and canned...");
                    break;
                case "main lobby":
                    Console.WriteLine("You go back to the main lobby");
                    Game.Transition<MainLobby>();
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
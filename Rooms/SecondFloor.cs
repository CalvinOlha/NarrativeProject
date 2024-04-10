using NarrativeProject.Rooms;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NarrativeProject.Rooms
{
    internal class SecondFloor : Room
    {
        internal static bool isKeyCollected;

        internal override string CreateDescription() =>
@"The second floor hallway is quiet and eerie.

A Gift Box is locked with the code [????].
You can return to your [main lobby].
You see a pink door that leads to the [kid's room].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "main lobby":
                    Console.WriteLine("You return to the Main Lobby.");
                    Game.Transition<MainLobby>();
                    break;
                case "1989":
                    Console.WriteLine($"•You opened the Gift Box. \n•Inside the Gift Box there was a Kids Bedroom Key! \n•You got the Kids Bedroom Key!");
                    //Console.WriteLine("The chest opens and you get a key.");
                    isKeyCollected = true;
                    break;
                case "kid's room":
                    Console.WriteLine("You enter the kid's room.");
                    Game.Transition<KidsRoom>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}

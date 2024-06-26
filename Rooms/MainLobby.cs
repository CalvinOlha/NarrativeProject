﻿using NarrativeProject.Rooms;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NarrativeProject.Rooms
{
    internal class MainLobby : Room
    {

        internal override string CreateDescription() =>
@"You wake up in the Main Lobby of the Rosemary Manor.

In front of you is the [front door], seems to be the way out of here.
To your right is the [bathroom].
To your left is the door to the [kitchen].
Behind you are the stairs that lead to the [2nd floor].
";


        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bathroom":
                    Console.WriteLine("You enter the bathroom.");
                    Game.Transition<Bathroom>();
                    break;
                case "front door":
                    if (!SecondFloor.isKeyCollected)
                    {
                        Console.WriteLine("The front door is locked.");
                    }
                    else
                    {
                        Console.WriteLine("You open the door with the key and leave the manor and for the Front Yard.");
                        Game.Transition<FrontYard>();
                    }
                    break;
                case "2nd floor":
                    Console.WriteLine("You go up to the 2nd floor.");
                    Game.Transition<SecondFloor>();
                    break;
                case "kitchen":
                    Console.WriteLine("You entered the kitchen.");
                    Game.Transition<Kitchen>();
                    break;
                case "pk teleport":
                    Console.WriteLine("You teleported to the front yard!");
                    Game.Transition<FrontYard>();
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

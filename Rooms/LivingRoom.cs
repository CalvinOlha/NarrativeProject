using NarrativeProject.Rooms;
using System;

namespace NarrativeProject
{
    internal class LivingRoom : Room
    {
        internal override string CreateDescription() =>
@"You are in the living room, the cat is sleeping on the couch.
The [tv] is in front of you.
The [front door] to your left leads outside.
Behind you is your [bedroom].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "tv":
                    Console.WriteLine("Nothing but static...");
                    break;
                case "front door":
                        Console.WriteLine("You leave your house.");
                    Game.Finish();
                    break;
                case "bedroom":
                    Console.WriteLine("You re-enter your bedroom and go to sleep. zzz...");
                    Game.Finish();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
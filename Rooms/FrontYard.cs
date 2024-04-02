using NarrativeProject.Rooms;
using System;

namespace NarrativeProject
{
    internal class FrontYard : Room
    {
        internal override string CreateDescription() =>
@"You are in the Front Yard, it is very quiet outside.
The [gate] in front of yo leads to the exit of the manor.
Behind you is [front door].
A [gravestone] is next to you.
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "gravestone":
                    Console.WriteLine("The grave has the letters 'XX' written on it and nothing else.");
                    break;
                case "gate":
                        Console.WriteLine("You managed to escape the manor!");
                        Console.WriteLine("");
                    Game.Finish();
                    break;
                case "front door":
                    Console.WriteLine("'No, I am not going back in there.'");
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
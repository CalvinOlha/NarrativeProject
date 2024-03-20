using System;

namespace NarrativeProject.Rooms
{
    internal class Bathroom : Room
    {
        internal static bool isShowCode;

        internal override string CreateDescription() =>
@"In your bathroom, the [bath] is filled with hot water.
The [mirror] in front of you reflects your depressed face.
You can return to your [bedroom].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bath":
                    Console.WriteLine("You relax in the bath. The room starts to steam up...");
                    isShowCode = true;
                    break;
                case "mirror":
                    if (isShowCode)
                    {

                        Console.WriteLine("You see the numbers 1989 written on the fog on your mirror.");

                    }
                    else
                    {

                        Console.WriteLine("You see vague shapes that ressemble numbers written on mirror.");
                    }
                    break;
                case "bedroom":
                    Console.WriteLine("You return to your bedroom.");
                    Game.Transition<Bedroom>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}

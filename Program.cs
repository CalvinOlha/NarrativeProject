using NarrativeProject.Rooms;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NarrativeProject
{
    //Basic idea: Make an MOTHER/EarthBound Beginnings inspired text-based game.
    //Take place in one of the locations from the game (maybe)
    //Items: Mostly stuff to recover HP, open doors or Gift Boxes and other items to help escape the building.
    //Make new rooms, remove the old ones

    /*
     Room ideas left: Basement, Attic, Garden, 2 Bedrooms (1 kids + 1 adult's)
    */

    /*
       Enemy ideas: Zombies, Ghosts, Bats, Ghost Armor, Bloody Zombie
    */
    [Serializable]  
    public class SaveData
    {
        public int numberToSave;
        public string stringToSave;

        public SaveData(int numberToSave, string stringToSave)
        {
            this.numberToSave = numberToSave;
            this.stringToSave = stringToSave;
        }
    }


    internal class Program
    {
        static SaveData saveData;
        static void Main(string[] args)
        {
            const string SaveFile = "Save.txt";
            if (!File.Exists(SaveFile))
            {
                File.CreateText(SaveFile);
            }

            var bf = new BinaryFormatter();

            //saveData = new SaveData(20, "Ninten");
            //bf.Serialize(File.OpenWrite(SaveFile), saveData);

            saveData = bf.Deserialize(File.OpenRead(SaveFile)) as SaveData;
            Console.WriteLine($"{saveData.stringToSave} has {saveData.numberToSave}$");

            var game = new Game(42);

            //Add expects a Room argument
            //Main Lobby is a Room (derived from base Room)
            //Becuase of Polymorphism, I can use Main Lobby as an argument
            //We substitute Main lobby into Room

            //If a code expects type A
            //It will also accept any type B
            //Given that B is a subtype of A
            //B is derived (inherited)
            //This is Polymorphism
            game.Add(new MainLobby());
            game.Add(new Bathroom());
            game.Add(new SecondFloor());
            game.Add(new FrontYard());
            game.Add(new Kitchen());

            while (!game.IsGameOver())
            {
                Console.WriteLine("—————————————————————————————————————————————————————");
                Console.WriteLine(game.CurrentRoomDescription);
                string choice = Console.ReadLine().ToLower() ?? "";;
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

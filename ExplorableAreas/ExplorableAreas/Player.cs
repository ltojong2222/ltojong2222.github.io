using System;
using System.Collections.Generic;
using System.IO;

namespace ExplorableAreasI
{
    class Player
    {
        public static string Name = "Anonymous Hero";
        public static List<string> Inventory = new List<string>();
        public static string DataFile = "data.txt";

        public static void GetPlayerName()
        {
            if (File.Exists(DataFile))
            {

                Name = File.ReadAllText(DataFile);
                Console.WriteLine("Welcome back " + Name + "! Ready for another traveling adventure?");
            }
            else
            {
                string name = "";
                Console.WriteLine("Please enter your name:");
                name = Console.ReadLine();
                File.WriteAllText(DataFile, name);
                Name = name;
            }


            Console.WriteLine("Press any key to continue...");
        }
    }
}

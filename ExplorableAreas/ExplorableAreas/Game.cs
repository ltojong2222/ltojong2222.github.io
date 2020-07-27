using System;
using System.Collections.Generic;
using static System.Console;

namespace ExplorableAreasI
{
    class Game
    {
        List<Location> locations = new List<Location>();
        Random random = new Random();

        public Game()
        {
            Title = "Explore Time!";
            Player.GetPlayerName();
            ReadKey();
            SetUp();
            Run();
        }
        public void Run()
        {
            string input = "";

            while (input != "x")
            {
                Clear();
                WriteLine("Your inventory: ");
                foreach (string s in Player.Inventory)
                {
                    WriteLine(s);
                }
                WriteLine("You find yourself on an adventure. " + Player.Name + ", where would you like to visit?");
                Menu();
                input = ReadLine();
                if (input == "x")
                {
                    //end game
                    WriteLine("Thanks for playing!");
                    ReadKey();
                }
                else
                {
                    //error checking would go here to make sure that it is a number
                    Travel(Convert.ToInt32(input));
                }

            }
        }
        public void Menu()
        {
            int i = 1;
            foreach (Location l in locations)
            {
                WriteLine(i + ". " + l.Name + " (" + l.Description + ")");
                i++;
            }
        }

        public void Travel(int choice)
        {
            int item = 0;
            Clear();
            choice--;
            WriteLine("You travel to " + locations[choice].Name);
            item = random.Next(locations[choice].Items.Length);

            if (locations[choice].Name == "Yharnam")
            {
                if (Player.Inventory.Contains("beast claw"))
                {
                    //they can enter the city
                }
                else
                {
                    Console.WriteLine("You're unprepared to enter here. The city is dangerous. Return after you have found a beast claw to defend yourself.");
                    Console.WriteLine("Press ENTER to continue...");
                    Console.ReadKey();
                    Run();
                }
            }

            if (locations[choice].Name == "Ba Sing Se")
            {
                if (Player.Inventory.Contains("passport"))
                {
                    //player can enter the city
                }
                else
                {
                    WriteLine("You wait in line at the checkpoint to enter the city. You are denied entry. Return after you've obtained a passport.");
                    WriteLine("Pree ENTER to continue...");
                    Console.ReadKey();
                    Run();
                }
            }

            if (locations[choice].Items[item] == "")
            {
                WriteLine("You look around the area. Nothing exciting. Not much to see right now. Maybe try visiting again later??");
            }
            else
            {
                WriteLine("You've found something! One " + locations[choice].Items[item] + " has been added to your inventory!");
                Player.Inventory.Add(locations[choice].Items[item]);
            }
            WriteLine("press ENTER to continue...");
            ReadKey();
            Run();
        }

        public void SetUp()
        {
            Title = "Let's Travel!";
            Location OldTownRoad = new Location("Old Town Road", "A western town where you ride 'til you can't no more. Yeehaw!", "cowboy hat", "boot spurs");
            Location ShellCity = new Location("Shell City", "A quaint, little gift shop", "Neptunian crown", "seashell");
            Location Yharnam = new Location("Yharnam", "A decrepit Gothic city...", "blood gem", "rune");
            Location Kamurocho = new Location("Kamurocho", "An entertainment district of Tokyo", "passport", "beast claw");
            Location GooLagoon = new Location("Goo Lagoon", "A popular beach destination", "sunscreen", "bubble buddy");
            Location BikiniBottom = new Location("Bikini Bottom", "A city under the sea", "krabby patty", "jellyfish");
            Location BaSingSe = new Location("Ba Sing Se", "An impenetrable city. There is no war in Ba Sing Se... ", "cabbage", "cup of tea");

            locations.Add(OldTownRoad);
            locations.Add(ShellCity);
            locations.Add(Yharnam);
            locations.Add(Kamurocho);
            locations.Add(GooLagoon);
            locations.Add(BikiniBottom);
            locations.Add(BaSingSe);
        }
    }
}
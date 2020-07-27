using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UnderwaterCreaturesSummer2020
{
    class Water
    {
        List<Creature> Creatures = new List<Creature> { 
            new Shrimp("Lenny","Shrimps have a heart and brain, but starfish don't.", "burbles"), 
            new Starfish("Patrick","Starfish eyes and mouth are under their body.", "shouts"),
            new Eel("Ed", "Eels live in both saltwater and fresh water.", "hisses"),
            new Tuna("Tommy", "Despite their large size, tunas are very fast swimmers.", "sings"),
            new Anchovy("Aaron", "Anchovies are classified as oily fish.", "bubbles"),
            new Mackerel("Haru", "Mackerels are carnivores.", "wiggles"),
            new Barracuda("Kevin", "Barracuda can swim 25 miles per hour.", "chomps"),
            new Plankton("Peter", "Plankton comes from the Greek word for 'drifter' or 'wanderer'.", "cackles")};

        //store food and item instances in a list or array (minimum 6 items)
        List<Item> Items = new List<Item> { new Food(), new Item() }; 
        public Water()
        {
            Title = "Water World!!!";
            WriteLine("Welcome!");
            Menu();
        }

        private void Menu()
        {
            string input;
            WriteLine("What would you like to do?");
            WriteLine("1) Show all creatures in the water.");
            WriteLine("2) Show a specific creature's name.");
            WriteLine("3) Show all creature appearances.");//Show a creature's appearance.
            WriteLine("4) ???");//Find food for creatures. (Random???)
            WriteLine("5) Exit application.");
            WriteLine("Enter a number: ");

            input = ReadLine();

            switch(input)
            {
                case "1":
                    ShowAllCreatures();
                    break;
                case "2":
                    ShowCreatureList();
                    break;
                case "3":
                    SeeCreatureAppearance();
                    break;
                case "4":
                    //FindFoodList
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    WriteLine("Please enter one of the choices above. Press ENTER to continue...");
                    ReadKey();
                    Menu();
                    break;


            }
            

            //ADD CREATURE INSTANCE
            private void SeeCreatureAppearance()
            {
                foreach (Creature creature in Creatures)
                {
                    WriteLine(creature.Name + "is " + creature.Appearance);
                }
            }
            ReadKey();
            Menu();
        }
        private void ShowAllCreatures()
        {
            //Show all creatures in the world
            //use a foreach loop to call their Talk methods
            foreach (Creature creature in Creatures)
            {
                WriteLine(creature.Name + " : " + creature.Description);
                WriteLine(creature.Talk());
                
                
            }
            WriteLine("Press ENTER to continue...");
            ReadKey();
        }
        private void ShowCreatureList()
        {
            //return type 
            for (int i = 0; i <Creatures.Count; i++)
            {
                WriteLine(i + 1 + ") " + Creatures[i].Name);
            }
            //TODO: let player enter a number of creature to choose
            WriteLine("Press ENTER to continue...");
            ReadKey();
        }
    }
}

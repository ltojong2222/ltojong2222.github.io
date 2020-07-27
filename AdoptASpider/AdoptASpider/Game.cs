/* Adopt an Insect by L. Tojong
 * SU 2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptASpider
{
    class Game
    {
        string Name;

        public Game()
        {
            Name = "Adopt A Spider";
            Console.Title = Name;
            Player.Pet = new Spider();
            Console.WriteLine("You decide to go to an animal shelter to adopt a new friend.");
            Console.WriteLine("You see all the abandoned spiders who need a home.");
            Console.WriteLine("There are many spiders to choose from!");
            Console.WriteLine("But first!! What is your name?");
            Player.Name = Console.ReadLine();
            Console.Write("Awesome! Nice to meet you, " + Player.Name + "!");
            Player.Name = Console.ReadLine();

            Console.WriteLine("What color is your spider?");
            Player.Pet.Color = Console.ReadLine();

            Console.WriteLine("What is your spider's name?");
            Player.Pet.Name = Console.ReadLine();

            Console.WriteLine("What is your spider's leg length?");
            Player.Pet.LegLength = Console.ReadLine();

            Player.Pet.Describe();
            Console.ReadKey();
        }
        public void ShowInput()
        {

        }
    }
}


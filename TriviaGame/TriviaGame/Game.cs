/*
 * Trivia Application by L. Tojong
 * Introduction to Programming, SU2020
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TriviaGame
{
    class Game
    {

        string gameName = "Trivia Game by L.";

        public Game()
        {
            Title = gameName;
            WriteLine("Welcome to " + gameName);
            WriteLine("Answer the questions as best you can!");

            WriteLine("What is your name?");
            Player.Name = ReadLine();
            WriteLine("Hello " + Player.Name + "! Let's play trivia!");
            Player.Name = ReadLine();
            Clear();

            Play();

            
        }

        private void Play()
        {
            TriviaItem tinkerbellPan = new TriviaItem();
            tinkerbellPan.Question = "What is the name of the fairy in Peter Pan?";
            tinkerbellPan.Answer = "Tinkerbell";

            TriviaItem starwarsDad = new TriviaItem();
            starwarsDad.Question = "In Star Wars, Palpatine reveals to Luke that he is his father. True or false?";
            starwarsDad.Answer = "false";

            TriviaItem animalCrossing = new TriviaItem();
            animalCrossing.Question = "Animal Crossing New Horizons is one of Nintendo's all time, best selling titles for the Switch. True or false?";
            animalCrossing.Answer = "true";

            TriviaItem boondocksThe = new TriviaItem();
            boondocksThe.Question = "What is the name of the suburb where the main characters of The Boondocks live?";
            boondocksThe.Answer = "Woodcrest";

            TriviaItem spongebobFriend = new TriviaItem();
            spongebobFriend.Question = "Who is Spongebob's best friend in Spongebob Squarepants?";
            spongebobFriend.Answer = "Patrick Star";

            TriviaItem johnWick = new TriviaItem();
            johnWick.Question = "Which actor portrays John Wick in the John Wick films? (Hint: Played Neo in The Matrix films)";
            johnWick.Answer = "Keanu Reeves";

            








            string input;
            WriteLine(tinkerbellPan.Question);
            input = ReadLine();
            WriteLine("Your answer: " + input + "." );
            WriteLine("The correct answer is Tinkerbell.");
            WriteLine("Press ENTER to continue...");
            ReadKey();
            Clear();

            WriteLine(starwarsDad.Question);
            input = ReadLine();
            WriteLine("Your answer is: " + input + ".");
            WriteLine("The correct answer is false. Darth Vader is Luke's father.");
            WriteLine("Press ENTER to continue...");
            ReadKey();
            Clear();

            WriteLine(animalCrossing.Question);
            input = ReadLine();
            WriteLine("Your answer is: " + input + ".");
            WriteLine("The correct answer is true. Animal Crossing New Horizons continues to sell more copies during these times!");
            WriteLine("Press ENTER to continue...");
            ReadKey();
            Clear();

            WriteLine(boondocksThe.Question);
            input = ReadLine();
            WriteLine("Your answer is: " + input + ".");
            WriteLine("The correct answer is Woodcrest.");
            WriteLine("Press ENTER to continue...");
            ReadKey();
            Clear();

            WriteLine(spongebobFriend.Question);
            input = ReadLine();
            WriteLine("Your answer: " + input + ".");
            WriteLine("The correct answer is Patrick Star.");
            WriteLine("Press ENTER to continue...");
            ReadKey();
            Clear();

            WriteLine(johnWick.Question);
            input = ReadLine();
            WriteLine("Your answer: " + input + ".");
            WriteLine("The correct answer is Keanu Reeves.");


            WriteLine("That's all! Thanks for playing trivia!");
            WriteLine("Press ENTER to continue to exit!!");
            ReadKey();
            Clear();

            

            //add statements here for gameee
        }
    }
}

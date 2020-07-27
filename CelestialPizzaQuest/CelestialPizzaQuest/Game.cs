using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CelestialPizzaQuest
{
    class Game
    {
        Player playerName;

        public Game()
        {
            playerName = new Player();
        }
        public void gameTitle()
        {


            string title = @"                                                                                                                                    
";
            WriteLine(title);
            ForegroundColor = ConsoleColor.Cyan;
            Read();

            WriteLine("=============================================");
            WriteLine("Celestial Pizza: A Space Pizza Text Adventure.");
            WriteLine("Press 'ENTER' to begin...");
            WriteLine("=============================================");
            ReadLine();
            Clear();
            first();

        }

        public void first()
        {
            string choice;

            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("==================================================================================================================");
            WriteLine("The year is 2155. Mars. Deimos City.");
            WriteLine("At the far edge of space lies 'Celestial Pizzeria', a popular pizza joint.");
            WriteLine("You are the pizza maker - one of the only humans on staff. It's a busy day today.");
            WriteLine("What is your name?");
            playerName.CharacterName = ReadLine();
            WriteLine("==================================================================================================================");
            WriteLine("Your character, " + playerName.CharacterName + ", stands in the kitchen.\nYou're at your prep station, awaiting orders.");
            WriteLine("A tall insect looking alien buzzes at you and gives you an order ticket. You read the ticket: ");
            WriteLine("Double extra large pizza with...\nExtra Earth cow cheese\nGarlic butter crust\nHalf pepperoni-oli\nHalf Blorian sausage\n2 blue olives\n3 pickles\n1 whole peppered pepper\nSprinkled jam slime");
            WriteLine("You adjust your apron and get to work.");
            WriteLine("You prep the pizza with ease...and place it into the oven.");
            WriteLine("As you wait for the pizza to finish, you get started on prepping a second pizza.\nAfter some time, you realize that you've left the first pizza in the oven for too long and it's gotten burnt!!\nThe orders are beginning to pile up and your alien co-workers are nagging at you...");
            WriteLine(playerName.CharacterName + ", What will you do?");
            WriteLine("1) Calm down and remake the first pizza");
            WriteLine("2) Prep the second pizza to be like the first one");
            WriteLine("3) Serve the burnt pizza");
            WriteLine("4) Do nothing");
            WriteLine("==================================================================================================================");
            Write("Choice: ");
            choice = ReadLine().ToLower();
            Clear();

            switch (choice)
            {

                case "4":
                case "do nothing":
                case "Do nothing":
                case "nothing":
                    {
                        WriteLine("=====================================================================================================");
                        WriteLine("You chose to do nothing.");
                        WriteLine("You break down and cry. Your human co-workers look at you in annoyance.");
                        WriteLine("Your six armed gelatinous boss, Detraf, stare daggers at you.");
                        WriteLine("Detraf yells at you and fires you.");
                        WriteLine("You're booted out of the restaraunt.");
                        WriteLine("You look at your " + playerName.Inventory[2].itemName + " and see a big fat 0. You are broke.\nYou shouldn't have spent the last of your money on " + playerName.Inventory[1].itemName);
                        WriteLine("You trudge back to your apartment in shame...");
                        WriteLine("=====================================================================================================");
                        WriteLine("Press 'ENTER' to continue...");
                        ForegroundColor = ConsoleColor.Red;
                        ReadLine();
                        gameOver();
                        break;

                    }


                case "3":
                case "serve the burnt pizza":
                case "Serve the burnt pizza":
                case "burnt pizza":
                    {
                        WriteLine("=====================================================================================================");
                        WriteLine("You chose to serve the burnt pizza.");
                        WriteLine("You place it on a platter to serve. Your insect looking alien co-worker buzzes at you and notices how burnt the pizza is.");
                        WriteLine("You can see how upset the customers are getting outside the kitchen..");
                        WriteLine("Your human co-workers look at you in disgust.");
                        WriteLine("Your six armed gelatinous boss, Detraf, drags you out of the kitchen and boots you out of the place.");
                        WriteLine("You've been fired!!");
                        WriteLine("=====================================================================================================");
                        WriteLine("Press 'ENTER' to continue...");
                        ForegroundColor = ConsoleColor.Red;
                        ReadLine();
                        gameOver();
                        break;
                    }
                case "2":
                case "prep second pizza":
                case "Prep":
                case "Prep the second pizza":
                    {
                        WriteLine("=================================================================================================================");
                        WriteLine("You chose to prep the second pizza.");
                        WriteLine("You attempt to calm down but some of the noise creates some anxiety in you.");
                        WriteLine("However, you work quickly and toss out the burnt pizza.");
                        WriteLine("The new pizza cooks wonderfully in the oven.");
                        WriteLine("You manage to get into the flow and soon the orders are made.");
                        WriteLine("It was a struggle but you did it.");
                        WriteLine("You're relieved you did good at work.");
                        WriteLine("You find out that a generous customer has left you " + playerName.Inventory[0].itemName + "!");
                        WriteLine("=================================================================================================================");
                        WriteLine("Press 'ENTER' to continue!");
                        ReadLine();
                        second();
                        break;
                    }
                case "1":
                case "calm down":
                case "Calm down":
                case "remake":
                case "Remake the first pizza":
                    {
                        WriteLine("======================================================================");
                        WriteLine("You chose to calm down and remake the first pizza.");
                        WriteLine("You concentrate...");
                        WriteLine("You block out all the noise and remake the first pizza from scratch.");
                        WriteLine("You get into a rhythm and work on the orders with ease.");
                        WriteLine("You can feel your co-workers looking at how fast you're making pizzas...They're impressed!!");
                        WriteLine("A rich alien customer awards you with a BIG tip.");
                        Console.WriteLine("You obtain " + playerName.Inventory[0].itemName + "!");
                        playerName.Inventory[0].itemUses--;
                        WriteLine("The rest of the work day goes well as you dance to the pizza groove.");
                        WriteLine("At the end of the day, you decide to use some of the tip to get a " + playerName.Inventory[1].itemName + ".");
                        WriteLine("You feel good!");
                        WriteLine("======================================================================");
                        WriteLine("Press 'ENTER' to continue.");
                        ReadLine();
                        second();
                        break;
                    }
                default:
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("=====================================");
                        WriteLine("I don't understand that command...");
                        WriteLine("=====================================");
                        WriteLine("Press 'ENTER' to try again...");
                        ResetColor();
                        ReadLine();
                        first();
                        break;
                    }

            }

        }

        public void second()
        {
            Random rnd = new Random();
            string[] secOptions = {"You make a stop at a soda shop and buy " +playerName.Inventory[1].itemName + ".",
            "You open up a bottle of ginger ale and drink it heartily. Nothing like a cold ginger ale after a hard day at work!!\nYou're skipping back to your place when a 4 legged alien with sunglasses stops you.",
            "You open up a bottle of ginger ale and drink it heartily. Nothing like a cold ginger ale after a hard day at work!!\nYou're skipping back to your place when a well dressed human stops you."};
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];

            string secChoice;

            WriteLine("======================================================================================================");
            WriteLine(secText);
            WriteLine("They give you a good look and smirk. 'Your name's " + playerName.CharacterName + ", yeah? How about coming with me for a sec?', they grin.\nYou start sweating.\nThey feel like trouble.");
            WriteLine("Do you want to run away; Yes or No?");
            WriteLine("======================================================================================================");
            Write("Choice: ");
            secChoice = ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                third();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                WriteLine("Before you can run, they grab your arm.");
                WriteLine("They drag you into an alley where you are sternly talked to about the pizza business and how you will never succeed at Celestial Pizzeria.");
                WriteLine("You feel down.");
                WriteLine("Press 'ENTER' to continue..");
                ReadLine();
                gameOver();
            }
            else
            {
                WriteLine("===============================");
                WriteLine("Command not recognized...");
                WriteLine("Press 'ENTER' to try again.");
                WriteLine("===============================");
                ReadLine();
                second();
            }
        }

        public void third()
        {
            int years;

            WriteLine("============================================================================================================");
            WriteLine("You gather your courage and run away. You run down the main street of the city.\nYou can feel every human and alien's stares as you run.");
            WriteLine("You're still carrying your pack of ginger ale as you slow down to a stop in front of a decent looking cafe.");
            WriteLine("You walk into the cafe and sit down at the counter. You catch your breath as you notice that the cafe's mostly populated with humans and a few aliens.");
            WriteLine("A gentlemanly alien with long fingers stands in front of you.");
            WriteLine("'You running from something, human?' , the alien asks.");
            WriteLine("'Y-yeah...' , you reply quietly. You find yourself unable to lie.");
            WriteLine("The alien hums.");
            WriteLine("'Wait a second...you're that human that works at THE Celestial Pizzeria!! You're " + playerName.CharacterName + "! You're the talk of the city!, the alien exclaims.");
            WriteLine("You get some glances. You blush.\n'So how long have you been in the pizza business?', the alien asks you.");
            WriteLine("You reply...");
            WriteLine("============================================================================================================");
            Write("Years worked: ");
            int.TryParse(ReadLine(), out years);

            while (years < 13)
            {
                WriteLine("'Really? I don't believe you!'");
                WriteLine("'Tell the truth!' , the alien exclaims.");
                WriteLine("===============================================");
                Write("Years worked: ");
                int.TryParse(ReadLine(), out years);
            }

            WriteLine("===================================================================================================");
            WriteLine("'Whooooa!', the alien is shocked. The customers are you gasp and continue to look at you.");
            WriteLine("You reveal you hail from the Earth city of Chicago - a pizza haven.\nAfter a good deal of talking about your pizza skills, you return home feeling overwhelmed with excitement.");
            WriteLine("===================================================================================================");
            youWin();
        }

        public void gameOver()
        {
            Clear();
            ForegroundColor = ConsoleColor.Red;
            WriteLine("====================================================================================");
            WriteLine("After that terrible night, you are haunted by your pizza nightmares.");
            WriteLine("You decide to move back home to Earth and attempt to find work there.\nYou can never touch a pizza again...");
            WriteLine("====================================================================================");
            WriteLine("Press 'ENTER' to try again...");
            WriteLine("====================================================================================");
            ReadLine();
            Clear();
            gameTitle();
        }

        public void youWin()
        {
            Clear();
            WriteLine("=======================================================================================================================");
            WriteLine("'Whooooa!', the alien is shocked. The customers are you gasp and continue to look at you.");
            WriteLine("You reveal you hail from the Earth city of Chicago - a pizza haven.\nAfter a good deal of talking about your pizza skills, you return home feeling overwhelmed with excitement.");
            WriteLine("Some time passes and you continue your pizza making work at the Celestial Pizzeria. You're admired among humans and aliens alike.");
            WriteLine("You've put the " + playerName.Inventory[0].itemName + " in your " + playerName.Inventory[2].itemName + ".\n You use your money well - getting a new place and investing in better pizza making tools.");
            WriteLine("You rise to the top of the pizza business. Your name becomes well known throughout space.");
            WriteLine("Some years pass, you become the head pizza maker of the Celestial Pizzeria!");
            WriteLine("=======================================================================================================================");
            WriteLine("Good job! You did it!" + playerName.CharacterName + " is the legend of the Celestial Pizzeria.");
            WriteLine("Press 'ENTER' to play again!");
            ReadLine();
            Clear();
            gameTitle();
        }
    }
}

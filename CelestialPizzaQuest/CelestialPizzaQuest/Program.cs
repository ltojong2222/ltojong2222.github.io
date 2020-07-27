//Adventure Game Project by L. Tojong
//Intro to Programming, SU 2020 
//7/26/2020
//ASCII art from https://ascii.co.uk/art/pizza
//Used programmingisfun.com for adventure game and console color help
//Used https://www.youtube.com/watch?v=3foH7ZfC-Hk&list=WL&index=72&t=177s for switch cases code(C# Text Adventure Game by MrStormUMA)
//Looked at https://www.youtube.com/watch?v=EURyF4U5OKw&t=545s for inspiration (C# Tutorial Text-Based Adventure Ep1: Getting Started by EnderUnknown)
//Looked at https://www.youtube.com/watch?v=6oad0kjMZQI for inspiration (C# Text Based Game Tutorial by Let's Tech Briefly)
//


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialPizzaQuest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "ASCII Art";
            string title = @"
   _____     _           _   _       _   _____ _              
  / ____|   | |         | | (_)     | | |  __ (_)             
 | |     ___| | ___  ___| |_ _  __ _| | | |__) | __________ _ 
 | |    / _ \ |/ _ \/ __| __| |/ _` | | |  ___/ |_  /_  / _` |
 | |___|  __/ |  __/\__ \ |_| | (_| | | | |   | |/ / / / (_| |
  \_____\___|_|\___||___/\__|_|\__,_|_| |_|   |_/___/___\__,_|


                                  ._
                                   ,(  `-.
                                 ,': `.   `.
                               ,` *   `-.   \
                             ,'  ` :+  = `.  `.
                           ,~  (o):  .,   `.  `.
                         ,'  ; :   ,(__) x;`.  ;
                       ,'  :'  itz  ;  ; ; _,-'
                     .'O ; = _' C ; ;'_,_ ;
                   ,;  _;   ` : ;'_,-'   i'
                 ,` `;(_)  0 ; ','       :
               .';6     ; ' ,-'~
             ,' Q  ,& ;',-.'
           ,( :` ; _,-'~  ;
         ,~.`c _','
       .';^_,-' ~
     ,'_;-''
    ,,~
    i'
    :
                                               
";

            Console.WriteLine(title);
            Console.Read();

            Game game = new Game();
            game.gameTitle();
        }
    }
}

//Data (Study Application) by L. Tojong
//Intro to Programming, SU 2020
//used ExternalData example as base code from programmingisfun.com by janell baxter
//used terms and defintions from Instantiation code
//changed Choice 2 from changing/updating content to accessing second .txt file with definitons 
using System;
using System.IO;

namespace DataStudyApp
{
    class Program
    {
        public static string DataFile1 = "terms.txt";
        public static string DataFile2 = "definitions.txt";
        public static string Content1 = "(Empty File)";
        public static string Content2 = "(Empty File)";
        public static string Input = "";
        public static bool Run = true;
        public static int Choice = 0;

        static void ColorText(string Message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(Message);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Console.Title = "Data Study Application";

            while (Run == true)
            {
                Menu();
            }
        }

        static void Menu()
        {
            string Input = "";
            int Choice = 0;

            Console.WriteLine("\n\n\n\n\n------------------------------------------");
            Console.WriteLine(" 1) See Terms 2) See Definitions 3) Exit");
            Console.WriteLine("------------------------------------------");

            Input = Console.ReadLine();
            Choice = Convert.ToInt32(Input);

            if (Choice == 1)
            {
                Console.Clear();
                if (File.Exists(DataFile1))
                {
                    ColorText("\n\nThe terms contents are:");
                    Content1 = File.ReadAllText(DataFile1);
                }
                Console.WriteLine(Content1);
            }
            else if (Choice == 2)
            {
                Console.Clear();
                if (File.Exists(DataFile2))
                {
                    ColorText("\n\nThe defintions contents are:");
                    Content2 = File.ReadAllText(DataFile2);
                }
                Console.WriteLine(Content2);
               
            }
            else
            {
                Run = false;
            }
        }
    }
}
//for .txt doc/external files
//string: alpha/numeric characters, like a sentence
//boolean: a true or false statement
//object: a particular instance of a class
//float: a number that can be a decimal but cannot be a large number
//double: a large number that can include a decimal
//interger: a whole number
//array: structures that organizes related data into sets
//lists: similar to arrays but more dynamic
//instance: a variable of any type contained within a class and is used to store object data
//private: a member access modifier
//public: most permissive access modifier 
//increment: increments its operand by 1
//for loop: loop through a block of code
//switch: select one of many code blocks to be executed
//while loop: a loop that can execute a block of code as long as a specified condition is met

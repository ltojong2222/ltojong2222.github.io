
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SubstitutionCipher
{
    class Cipher
    {

        public static void Encrypt()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string different = "zyxwvutsrqponmlkjihgfedcba";


            WriteLine("Hello there agent!");
            WriteLine("Enter lowercase text.");
            string decipher = ReadLine();

            foreach (char c in decipher)
            {
                int index = alphabet.IndexOf(c);
                decipher = decipher.Replace(c, different[index]);
            }
            WriteLine("Your encryptid statement is: " + decipher);
            WriteLine("Thanks for playing!");
            WriteLine("Press ENTER to exit...");
        }
    }
}

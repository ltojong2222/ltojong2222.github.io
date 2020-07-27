using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderwaterCreaturesSummer2020
{
    public class Creature
    {
        //TODO: Minimum 4 properties
        public string Name;
        public string Description;
        public string CommunicationMethod;
        public string Appearance;

        //Minimum 4 Methods - can include constructor(s)
        //This below is polymorphism!!!
        public Creature()
        {

        }
        public Creature(string name, string description, string communicationmethod)
        {
            Name = name;
            Description = description;
            CommunicationMethod = communicationmethod;

        }
        public void Eat() { }
        public string Talk() 
        {
            return $"{Name} {CommunicationMethod}.";
        }

        public string Look()
        {
            $"{Name} is {Appearance}.";
        }

        //public string Look()
        //{
        //  $"{Name} is {Appearance)}.";
        //}
        public void Sleep() { }


    }
}

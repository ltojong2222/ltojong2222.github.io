using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderwaterCreaturesSummer2020
{
    public class Anchovy : Creature
    {
        public Anchovy() { }

        public Anchovy(string name, string description, string communicationmethod) : base(name, description, communicationmethod)
        {
            Name = name;
            Description = description;
            CommunicationMethod = communicationmethod;

        }
    }
}

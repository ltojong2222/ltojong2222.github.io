using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptASpider
{
    class Spider
    {
        public string LegLength = "long";
        public string Color = "blue";
        public string Name = "Jack";

        public void Eat()
        {

        }

        public void Describe()
        {
            Console.WriteLine("You've adopted a " + Color + " spider with " + LegLength + "legs named " + Name + ", who is now your best friend! Congrats!");
        }
    }
}

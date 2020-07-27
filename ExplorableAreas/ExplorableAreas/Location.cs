using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorableAreasI
{
    class Location
    {
        public string Name = "";
        public string Description = "";
        public string[] Items = new string[] { "", "", "peach", "can of Sunkist", "pair of sunglasses", "" };

        public Location()
        {
        }

        public Location(string name, string description, string item1, string item2)
        {
            Name = name;
            Description = description;
            Items[0] = item1;
            Items[1] = item2;
        }
    }
}
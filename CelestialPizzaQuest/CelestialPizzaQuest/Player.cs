using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialPizzaQuest
{
    public class Player
    {
        public string CharacterName;
        private Item[] inventory;
        

        public Player()
        {
            Inventory = new Item[3];
            Item goodpizza = new Item();
            goodpizza.itemName = "huge tip of 500000 galactic dollars";
            goodpizza.itemUses = 3;

            Item badpizza = new Item();
            badpizza.itemName = "six pack of ginger ale";
            badpizza.itemUses = 4;

            Item galactictip= new Item();
            galactictip.itemName = "savings account";
            galactictip.itemUses = 2;


            Inventory[0] = goodpizza;
            Inventory[1] = badpizza;
            Inventory[2] = galactictip;
        }

        internal Item[] Inventory { get => inventory; set => inventory = value; }
    }
}

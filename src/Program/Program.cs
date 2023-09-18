using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Item sword = new(50, 0);
            Item armor = new(0, 30);
            Item swordSuprema = new(80, 0);
            Item armorLegendaria = new(0, 60);
            
            List<Item> itemsManu = new List<Item> {sword, armor};
            Elf elfo = new("Manu", itemsManu);

            
            List<Item> itemsAgus = new List<Item> {swordSuprema, armorLegendaria};
            Dwarf dwarf  = new("Agus", itemsAgus);
        }
    }
}

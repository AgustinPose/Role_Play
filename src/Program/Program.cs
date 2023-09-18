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
            
            List<Item> itemsManu = new List<Item> {sword, armor};
            Elf elfo = new("Manu", itemsManu);
        }
    }
}

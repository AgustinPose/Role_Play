//Manuela

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Library
{
    public class Elf
    {
        private double lives = 100;
        public double Lives { get => lives; }
        public string Name { get; set;}
        public ArrayList Items { get; set; }

        public Elf (string name, ArrayList items)
        {
            this.Name = name;
            this.Items = items;
        }
        
        public void AddItem(object newItem)
        {
            Items.Add(newItem);
        }

        public void RemoveItem(object item)
        {
            Items.Remove(item);
        }

        public void GetAttackValue()
        {

        }

        public void GetDefenseValue()
        {

        }


        public void AttackWizard(object wizard)
        {
            // tinen que estar las otras clases creadas
        }

        public void AttackElf(Elf elf)
        {
            if (! ReferenceEquals(this, elf))
            {

            }
        }

        public void AttackDwarf(object dwarf)
        {

        }

        public void Heal(int heal)
        {
            if (lives + heal <= 100)
            {
                lives += heal;
            }
        }
    }
}
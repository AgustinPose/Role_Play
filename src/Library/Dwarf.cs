//Agustin

using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class Dwarf
    {
        //private double lives = 100;
        public double Lives { get; private set; }
        public string Name { get; set; }
        public List<Item> Items { get; set; }

        public double GetTotalAttack()
        {
            double attack = 0;
            foreach (var item in Items)
            {
                attack += item.AttackValue;
            }
            return attack;
        }

        public double GetTotalDefense()
        {
            double defense = 0;
            foreach (var item in Items)
            {
                defense += item.DefenseValue;
            }
            return defense;
        }

        public Dwarf(string name, List<Item> items)
        {
            this.Name = name;
            this.Items = items;
            this.Lives = 150;
        }

        public void AddItem(Item newItem)
        {
            Items.Add(newItem);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        
        public void AttackWizard(Wizard targetWizard)
        {
            double damage = this.GetTotalAttack();
            targetWizard.TakeDamage(damage);
        }

        public void AttackElf(Elf targetElf)
        {
            double damage = this.GetTotalAttack();
            targetElf.TakeDamage(damage);
        }

        public void AttackDwarf(Dwarf targetDwarf)
        {
            if (targetDwarf != this)
            {
                double damage = this.GetTotalAttack();
                targetDwarf.TakeDamage(damage);
            }

        }
        public void TakeDamage(double amount)
        {
            double defense = this.GetTotalDefense();
            if (amount < defense)
            {
                double currentDefense;
                foreach (Item item in Items)
                {
                    currentDefense = item.DefenseValue;
                    if (amount >= currentDefense)
                    {

                        amount -= currentDefense;
                        Items.Remove(item);
                    }
                    else
                    {
                        item.DefenseValue -= amount;
                    }
                    if (amount == 0)
                    {

                        break;
                    }
                }
            }
            else if (amount > defense)
            {
                amount -= defense;
                Lives -= amount;
            }


            // Sé que el que esto esté acá está mal por donde lo mires, pero no se dónde ponerlo
            if (Lives <= 0)
            {
                Console.WriteLine("Personaje muerto");
            }
        }

        public void SetHeal()
        {
            this.Lives = 100;
        }


    }
}
 
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

        public double TotalDefense
        {
            get 
            {
                double totalDefense = 0;    
                foreach(Item item in Items)
                {
                    totalDefense += item.DefenseValue;
                }
                return totalDefense;   
            }
        }
        private double TotalAttack
        {
            get
            {
                double totalAttack = 0;
                foreach(Item item in Items)
                {
                    totalAttack += item.AttackValue;
                }
                return totalAttack;
            }
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

        /*public double GetAttackValue()
        {
            double totalAttack = 0.0;

            int attack = 0;
            foreach (var item in Items)
            {
                attack += item.AttackValue;
            }
            return attack;
        } */

        // public int GetDefenseValue()
        // {
        //     int defense = 0;
        //     foreach (var item in items)
        //     {
        //         defense += item.DefenseValue;
        //     }
        //     return defense;
        // }

        public void AttackWizard(Wizard wizard)
        {
            // Implementar la lógica para que este Dwarf ataque a un Wizard aquí
        }

        public void AttackElf(Elf elf)
        {
            // Implementar la lógica para que este Dwarf ataque a un Elf aquí
        }



        /*public void AttackDwarf(Dwarf dwarf)
        {
            if (!ReferenceEquals(this, dwarf))
            {
                // Calcula el daño causado por este Dwarf al objetivo
                double damage = this.GetAttackValue() - dwarf.GetDefenseValue();

                // Aseggurar de que el daño no sea negativo
                if (damage > 0)
                {
                    dwarf.ReceiveDamage(damage);
                }
            }
        }*/

        //private void ReceiveDamage(double damage)
       // {
         //   lives -= damage;
//
  //          if (lives < 0)
    //        {
      //          lives = 0; // Para evitar valores negativos
        //    }
        //}
       public void TakeDamage(double amount) 
        {
            double defense = this.TotalDefense;
            if (amount < defense)
            {
                double currentDefense;
                foreach(Item item in Items)
                {
                    currentDefense = item.DefenseValue;
                    if(amount >= currentDefense)
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
            } else if (amount > defense)
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

//Manuela

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Library
{
    public class Elf
    {
        private int totalHealings = 5;
        public double Lives { get; private set; }
        public string Name { get; set;}
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

        public Elf (string name, List<Item> items)
        {
            this.Name = name;
            this.Items = items;
            this.Lives = 100;
        }
        
        public void AddItem(Item newItem)
        {
            Items.Add(newItem);
        }

        public void RemoveItem(Item currentItem)
        {
            Items.Remove(currentItem);
        }

        public double GetAttackValue()
        {
            return this.TotalDefense;
        }

        public double GetDefenseValue()
        {
            return this.TotalAttack;
        }

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

        public void AttackWizard(Wizard targetWizard)
        {
            double damage = this.TotalAttack;
            targetWizard.TakeDamage(damage);
        }

        public void AttackElf(Elf targetElf)
        {
            if (targetElf != this)
            {
                double damage = this.TotalAttack;
                targetElf.TakeDamage(damage);
            }
        }

        public void AttackDwarf(Dwarf targetDwarf)
        {
            double damage = this.TotalAttack;
            targetDwarf.TakeDamage(damage);
        }

        public void SetHeal()
        {
            this.Lives = 100;
        }

        public void HealWizard(Wizard wizard)
        {
            if (totalHealings > 0)
            {
                wizard.SetHeal();
                totalHealings -= 1;
            }
        }

        public void HealDwarf(Dwarf dwarf)
        {
            if (totalHealings > 0)
            {
                dwarf.SetHeal();
                totalHealings -= 1;
            }
        }

        public void HealElf(Elf elf)
        {
            if (totalHealings > 0)
            {
                elf.SetHeal();
                totalHealings -= 1;
            }
        }
    }
}

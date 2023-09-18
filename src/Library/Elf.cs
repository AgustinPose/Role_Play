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

        public void TakeDamage(double amount) 
        {
            double defense = GetTotalDefense();
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
        }

        public void AttackWizard(Wizard targetWizard)
        {
            double damage = GetTotalAttack();
            targetWizard.TakeDamage(damage);
        }

        public void AttackElf(Elf targetElf)
        {
            if (targetElf != this)
            {
                double damage = GetTotalDefense();
                targetElf.TakeDamage(damage);
            }
        }

        public void AttackDwarf(Dwarf targetDwarf)
        {
            double damage = GetTotalAttack();
            targetDwarf.TakeDamage(damage);
        }

        public void Heal()
        {
            this.Lives = 100;
        }

        public void HealWizard(Wizard wizard)
        {
            if (totalHealings > 0)
            {
                wizard.Heal();
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
                elf.Heal();
                totalHealings -= 1;
            }
        }

        public void CheckDeath()
        {
            if (this.Lives <= 0)
            {
                //Muere
                Console.WriteLine($"{this.Name} ha muerto");
            }
        }
    }
}

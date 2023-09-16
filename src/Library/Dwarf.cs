//Agustin

using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class Dwarf
    {
        private double lives = 100;
        public double Lives { get => lives; }
        public string Name { get; set; }
        public ArrayList Items { get; set; }

        public Dwarf(string name, ArrayList items)
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

        private void ReceiveDamage(double damage)
        {
            lives -= damage;

            if (lives < 0)
            {
                lives = 0; // Para evitar valores negativos
            }
        }


        public void Heal(int heal)
        {
            if (lives + heal <= 100)
            {
                lives += heal;
            }
            else
            {
                lives = 100; // Limitamos la vida máxima a 100
            }
        }
    }
}

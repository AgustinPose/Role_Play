// Santiago
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Item
    {
        public int AttackValue{ get; } 
        public int DefenseValue {get;}
        public Item(int attackValue, int defenseValue)
        {
        AttackValue = attackValue;
        DefenseValue = defenseValue;
        }
    }

    public class WizardItems
    {
        private List<Item> itemList = new List<Item>();

        public void AddItem(Item item)
        {
            itemList.Add(item);
        }

        public void RemoveItem(Item item)
        {
            itemList.Remove(item);
        }

        public int GetTotalAttack()
        {
            return itemList.Sum(item => item.AttackValue);
        }

        public int GetTotalDefense()
        {
            return itemList.Sum(item => item.DefenseValue);
        }
    }

    public class ElfItems
    {
        private List<Item> itemList = new List<Item>();

        public void AddItem(Item item)
        {
            itemList.Add(item);
        }

        public void RemoveItem(Item item)
        {
            itemList.Remove(item);
        }

        public int GetTotalAttack()
        {
            return itemList.Sum(item => item.AttackValue);
        }

        public int GetTotalDefense()
        {
            return itemList.Sum(item => item.DefenseValue);
        }
    }

    public class DwarfItems
    {
        private List<Item> itemList = new List<Item>();

        public void AddItem(Item item)
        {
            itemList.Add(item);
        }

        public void RemoveItem(Item item)
        {
            itemList.Remove(item);
        }

        public int GetTotalAttack()
        {
            return itemList.Sum(item => item.AttackValue);
        }

        public int GetTotalDefense()
        {
            return itemList.Sum(item => item.DefenseValue);
        }
    }
}
// Santiago
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class ItemSanti
    {
        public int AttackValue{ get; } 
        public int DefenseValue {get;}
        public ItemSanti(int attackValue, int defenseValue)
        {
        AttackValue = attackValue;
        DefenseValue = defenseValue;
        }
    }

    public class WizardItems
    {
        private List<ItemSanti> itemList = new List<ItemSanti>();

        public void AddItem(ItemSanti item)
        {
            itemList.Add(item);
        }

        public void RemoveItem(ItemSanti item)
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
        private List<ItemSanti> itemList = new List<ItemSanti>();

        public void AddItem(ItemSanti item)
        {
            itemList.Add(item);
        }

        public void RemoveItem(ItemSanti item)
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
        private List<ItemSanti> itemList = new List<ItemSanti>();

        public void AddItem(ItemSanti item)
        {
            itemList.Add(item);
        }

        public void RemoveItem(ItemSanti item)
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
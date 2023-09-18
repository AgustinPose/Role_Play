using System.Collections;

namespace Library
{
    public class Item
    {
        public double AttackValue { get; private set;}
        public double DefenseValue { get; set;}
        public Item(double attackValue, double defenseVale)
        {
            this.AttackValue = attackValue;
            this.DefenseValue = defenseVale;
        }

    }
}

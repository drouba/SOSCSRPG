using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Weapon : GameItem
    {

        public int MinimumDamage { get; set; }
        public int MaximumDammage { get; set; }

        public Weapon(int itemTypeID, string name, int price, int minDammage, int maxDammage) 
            : base(itemTypeID, name, price)
        {
            MinimumDamage = minDammage;
            MaximumDammage = maxDammage;

        }

        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, MinimumDamage, MaximumDammage);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStore
{
    public class Shield : Item
    {
        public float DamageModifier { get; set; }

        public Shield(string name, string description, decimal price, float damageModifier)
        {
            Name = name;
            Description = description;
            Price = price;
            DamageModifier = damageModifier;
        }

        public float Block(float baseDamage)
        {
            var blockedDamage = DamageModifier;

            Console.WriteLine("You use " + Name + " to block " + blockedDamage + " damage.");

            return baseDamage - blockedDamage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStore.Models.Items
{
    public class Sword : Item
    {
        public int Damage { get; set; }

        public Sword(string name, string description, decimal price, int damage)
        {
            Name = name;
            Description = description;
            Price = price;
            Damage = damage;
        }

        public void Attack()
        {
            Console.WriteLine("You swing a " + Name + " and deal " + Damage + " damage.");
        }
    }
}

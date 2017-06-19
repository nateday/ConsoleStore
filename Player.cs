using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStore
{
    public class Player
    {
        string Name { get; set; }
        float Health { get; set; }

        List<Item> Inventory;
        Sword EquipedSword;
        Shield EquipedShield;
        ChestPlate EquipedChestPlate;

        public Player(string name, float health)
        {
            Name = name;
            Health = health;

            Inventory = new List<Item>();
        }

        public void Attack()
        {
            if (EquipedSword != null)
            {
                EquipedSword.Attack();
            }
            else
            {
                Console.WriteLine("Player has no Sword... Throws punch instead. Deals: 1 damage.");
            }
        }

        public void OnAttacked()
        {
            float DamageTaken = 10;

            if (EquipedShield != null)
            {
               DamageTaken = EquipedShield.Block(DamageTaken);
            }
            else
            {
                Console.WriteLine("Player does not have a shield! You can buy one at the store.");
            }

            Health -= DamageTaken;
        }

        public void EquipSword()
        {
            var sword = Inventory.FirstOrDefault(i => i is Sword);

            if (sword != null)
            {
                EquipedSword = sword as Sword;
            }
        }

        public void EquipShield()
        {
            var shield = Inventory.FirstOrDefault(i => i is Shield);

            if (shield != null)
            {
                EquipedShield = shield as Shield;
            }
        }

        public void EquipChestPlate()
        {
            var chestPlate = Inventory.FirstOrDefault(i => i is ChestPlate);

            if (chestPlate != null)
            {
                EquipedChestPlate = chestPlate as ChestPlate;

                Health += EquipedChestPlate.HealthModifier;
            }
        }
    }
}

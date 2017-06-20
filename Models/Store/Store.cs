using ConsoleStore.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStore.Models.Store
{
    public class Store
    {
        private List<Item> items;
        private List<Item> cart;

        public string Name { get; private set; }

        public Store(string name)
        {
            Name = name;
            items = new List<Item>();
            cart = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(string itemName)
        {
            var item = items.FirstOrDefault(i => i.Name == itemName);

            if(item != null)
            {
                items.Remove(item);
            }
        }

        public void AddItemToCart(string itemName)
        {
            var item = items.FirstOrDefault(i => i.Name == itemName);

            AddItemToCart(item);
        }

        public void AddItemToCart(Item item)
        {
            RemoveItem(item.Name);

            cart.Add(item);
        }

        public void RemoveItemFromCart(string itemName)
        {
            var item = items.FirstOrDefault(i => i.Name == itemName);

            cart.Remove(item);

            AddItem(item);

        }

        public void CalculateCartTotal()
        {
            var total = cart.Sum(i => i.Price);

            Console.WriteLine("Total amount due: {0:C}", total);
        }

        public void ViewItems()
        {
            Console.WriteLine("Items in Armory:");
            items.ForEach(i => i.Display());
        }

        public void ViewCart()
        {
            Console.WriteLine("Items in cart:");
            cart.ForEach(i => i.Display());
            CalculateCartTotal();
        }

        public Item GetItemByName(string itemName)
        {
            var item = items.FirstOrDefault(i => i.Name == itemName);

            if(item != null)
            {
                return item;
            }
            else
            {
                return null;
            }
        }
    }
}

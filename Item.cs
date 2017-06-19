using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStore
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        //public Item(string name, string description, decimal price)
        //{
        //    Name = name;
        //    Description = description;
        //    Price = price;
        //}

        //public void Display()
        //{
        //    Console.WriteLine("Item: {0}. Price: {1:C}. Description: {2}", Name, Price, Description);
        //}
    }
}

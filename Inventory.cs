using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Inventory
    {
        private List<Item> items;

        public List<Item> Items { get { return items; } }

        public Inventory()
        {
            items = new List<Item>();
        }

        public void AddToInventory(Item item)
        {
            items.Add(item);
        }

        public void UseFromInventory(Item item)
        {
            items.Remove(item);
        }
    }
}

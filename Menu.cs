using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPO5
{
    public class Menu
    {
        public List<Item> Items { get; private set; }

        public Item Item
        {
            get => default;
            set
            {
            }
        }

        public Menu()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Меню:");
            foreach (var item in Items)
            {
                Console.WriteLine(item.GetDetails());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRPO5;

namespace VRPO5
{
    public class Order
    {
        public List<Item> Items { get; private set; }
        public double TotalAmount { get; private set; }
        public string Status { get; set; } // Изменено на public string Status { get; set; }

        public Item Item
        {
            get => default;
            set
            {
            }
        }

        public Order(List<Item> items)
        {
            Items = items;
            CalculateTotal();
            Status = "Pending";
        }

        public void ConfirmOrder()
        {
            Status = "Confirmed";
        }

        public void CancelOrder()
        {
            Status = "Cancelled";
        }

        public void CalculateTotal()
        {
            TotalAmount = 0;
            foreach (var item in Items)
            {
                TotalAmount += item.Price;
            }
        }
    }

}

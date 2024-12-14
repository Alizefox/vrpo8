using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRPO5;

namespace VRPO5
{
    public class Client : Order
    {
        public string Name { get; set; }
        public Order Order { get; private set; }

        public Bill Bill
        {
            get => default;
            set
            {
            }
        }

        public Client(string name)
        {
            Name = name;
        }

        public void MakeOrder(List<Item> items)
        {
            Order = new Order(items);
            Console.WriteLine($"{Name} сделал заказ.");
        }

        public void PayBill(Bill bill)
        {
            if (bill.IsPaid)
            {
                Console.WriteLine("Счет уже оплачен.");
            }
            else
            {
                bill.Pay();
                Console.WriteLine($"{Name} оплатил счет.");
            }
        }
    }
}

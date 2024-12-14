using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPO5
{
    public class Bill
    {
        public double Amount { get; private set; }
        public bool IsPaid { get; private set; }

        public Bill(double amount)
        {
            Amount = amount;
            IsPaid = false;
        }

        public void GenerateBill()
        {
            Console.WriteLine($"Счет на сумму: {Amount:C}");
        }

        public void Pay()
        {
            IsPaid = true;
            Console.WriteLine("Счет оплачен.");
        }
    }
}


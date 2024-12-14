using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPO5
{
    public static class Kitchen
    {
        public static Administrator Administrator
        {
            get => default;
            set
            {
            }
        }

        public static void PrepareOrder(Order order)
        {
            Console.WriteLine("Приготовление заказа...");
            order.Status = "In Kitchen";
        }

        public static void CompleteOrder(Order order)
        {
            order.Status = "Completed";
            Console.WriteLine("Заказ выполнен.");
        }
    }
}

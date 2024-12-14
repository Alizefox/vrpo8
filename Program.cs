using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPO5
{
    //internal class Program
    //{

    //    static void Main(string[] args)
    //    {
    //    }
    //}
    public class Program
    {
        public static void Main(string[] args)
        {
            // Создание меню
            Menu menu = new Menu();
            menu.AddItem(new Item("Пицца", 8.50));
            menu.AddItem(new Item("Салат", 5.00));
            menu.AddItem(new Item("Суп", 3.50));

            // Создание клиента и администратора
            Client client = new Client("Иван");
            Administrator admin = new Administrator("Светлана");

            // Отображение меню
            menu.DisplayMenu();

            // Клиент делает заказ
            client.MakeOrder(new List<Item> { menu.Items[0], menu.Items[1] });
            admin.ConfirmOrder(client.Order);
            admin.SendToKitchen(client.Order);

            // Создание и оплата счета
            Bill bill = admin.CreateBill(client.Order);
            bill.GenerateBill();
            client.PayBill(bill);
        }
    }
}

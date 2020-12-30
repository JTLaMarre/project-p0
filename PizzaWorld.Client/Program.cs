using System;
using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;


namespace PizzaWorld.Client
{
    class Program
    {


        private static readonly SqlClient _sql = new SqlClient();
        static void Main(string[] args)
        {
           
            UserView();
        }



        static void PrintAllStoresEF()
        {
            foreach (var s in _sql.ReadStores())
            {
                Console.WriteLine(s);
            }
        }

        static void UserView()
        {
            var user = new User();
            var ThisOrder = new Order();
            PrintAllStoresEF();

            user.SelectedStore = _sql.SelectStore();
            user.SelectedStore.CreateOrder();
            user.Orders = user.SelectedStore.Orders;
            user.Orders.Add(user.SelectedStore.Orders.Last());
            ThisOrder = user.SelectedStore.Orders.Last();
            ThisOrder.DisplayPizzaOptions();
            ThisOrder.AddPizza();
            user.SelectedStore.Revenue = user.SelectedStore.Revenue + ThisOrder.Total;
            _sql.Update(user.SelectedStore);
            _sql.OrdersPizzas(ThisOrder.EntityId);
            Console.WriteLine(user);
            ViewStoreRev(user.SelectedStore);
            

        }

        static void ViewStoreRev(Store s)
        {
            Console.WriteLine("Type Store Id to view current revenue");
            var StoreId = s.EntityId;
            var input = long.Parse(Console.ReadLine());
            if (input == StoreId)
            {

                Console.WriteLine($"${s.Revenue}");
            }
            else
            {
                Console.WriteLine("Store ID not recognize access to revenue denied");
            }
        }
        
        static void ViewOrderHistory(User u)
        {
            foreach (Order Order in u.Orders)
            {
                Console.WriteLine(Order.Pizzas + "\n");
            }
        }
    }
}

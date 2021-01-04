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
        static void PrintAllUsersEF()
        {
            foreach (var u in _sql.ReadUsers())
            {
                Console.WriteLine(u.Name);
            }
        }
        static void OrderOrHistory(User u)
        {
            Console.WriteLine("--- Hello Returning User -- type 1 to view your order history or 0 to start a new order");
            int.TryParse(System.Console.ReadLine(), out int input);
            if (input == 1)
            {
                _sql.ReadUsersPizzas(_sql.UsersOrders(u));
            }
            else
            {
                var ThisOrder = new Order();
                ThisOrder.UserEntityId = u.EntityId;
                PrintAllStoresEF();
                Console.WriteLine("--- Type Store Name to select a store ---");
                u.SelectedStore = _sql.SelectStore();
                u.SelectedStore.CreateOrder();
                u.Orders = u.SelectedStore.Orders;
                u.Orders.Add(u.SelectedStore.Orders.Last());
                ThisOrder = u.SelectedStore.Orders.Last();
                ThisOrder.DisplayPizzaOptions();
                ThisOrder.AddPizza();
                _sql.Update();
                _sql.ReviewOrder(ThisOrder);
                u.SelectedStore.Revenue = u.SelectedStore.Revenue + ThisOrder.Total;
                _sql.Update();
                Console.WriteLine(u);
                ViewStoreRev(u.SelectedStore);
            }
        }

        static void UserView()
        {
            PrintAllUsersEF();
            Console.WriteLine("--- Type User Name to select User ---");
            var user = _sql.SelectUser();
            OrderOrHistory(user);






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
    }
}

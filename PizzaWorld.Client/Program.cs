using System;
using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;
using PizzaWorld.Domain.Singletons;

namespace PizzaWorld.Client
{
    class Program
    {
        private static readonly ClientSingleton _client = ClientSingleton.Instance;

        private static readonly SqlClient _sql = new SqlClient();
        static void Main(string[] args)
        {

            UserView();
        }

        static IEnumerable<Store> GetAllStores()
        {
            return _client.Stores;
        }
        // static void PrintAllStores()
        // {
        //     foreach (var store in _client.Stores)
        //     {
        //         Console.WriteLine(store);
        //     }
        // }
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

            user.SelectedStore = _client.SelectStore();
            user.SelectedStore.CreateOrder();

            user.Orders = user.SelectedStore.Orders;
            user.Orders.Add(user.SelectedStore.Orders.Last());
            ThisOrder = user.SelectedStore.Orders.Last();
            //   todo Select Order method
            ThisOrder.DisplayPizzaOptions();
            ThisOrder.AddPizza();


            System.Console.WriteLine(user);
        }
    }
}

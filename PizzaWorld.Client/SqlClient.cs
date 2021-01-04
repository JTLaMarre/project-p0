using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;
using PizzaWorld.Storing;

namespace PizzaWorld.Client
{
    public class SqlClient
    {
        public SqlClient()
        {
            if (ReadStores().Count() == 0)
            {
                CreateStore();
            }
        }
        private readonly PizzaWorldContext _db = new PizzaWorldContext();
        public IEnumerable<Store> ReadStores()
        {
            return _db.Stores;
        }
        public IEnumerable<User> ReadUsers()
        {
            return _db.Users;
        }
        public User SelectUser()
        {
            string input = Console.ReadLine();
            return ReadOneUser(input);
        }
        public User ReadOneUser(string name)
        {

            return _db.Users.FirstOrDefault(s => s.Name == name); // linq predicate
        }

        public void Save(Store store)
        {
            _db.Add(store);
            _db.SaveChanges();
        }
        public void Update(Store store)
        {
            _db.SaveChanges();
        }
        public void CreateStore()
        {
            Save(new Store());
        }
        public Store ReadOne(string name)
        {

            return _db.Stores.FirstOrDefault(s => s.Name == name); // linq predicate
        }
        public Store SelectStore()
        {
            string input = Console.ReadLine();
            return ReadOne(input);
        }
        public void OrdersPizzas(long num)
        {
            Console.WriteLine("---- You Have Ordered ----");
            foreach (APizzaModel p in _db.Pizzas)
            {
                if (p.OrderId == num)
                {
                    Console.WriteLine($"{p.Name} id: {p.EntityId}");
                }
            }
        }
        public IEnumerable<APizzaModel> ReadPizzas()
        {
            return _db.Pizzas;
        }
        public APizzaModel ReadOneP(long Id)
        {

            return _db.Pizzas.FirstOrDefault(p => p.EntityId == Id); // linq predicate
        }


        public void ReviewOrder(Order o)
        {
            var p = ReadPizzas();
            OrdersPizzas(o.EntityId);
            Console.WriteLine("Type Pizza id to remove from order or 0 to verify order is correct.");
            long.TryParse(System.Console.ReadLine(), out long input);
            if (input == 0)
            {
                Console.WriteLine("Order Wrapping up");
                OrdersPizzas(o.EntityId);
            }
            // todo figure out how to check if input is a pizza ID for now just expecting a user not to goof
            else
            {
                o.Total =o.Total -10;
                DeletePizza(input);

                ReviewOrder(o);
            }
        }

        public void DeletePizza(long num)
        {
            _db.Remove(_db.Pizzas.Single(p => p.EntityId == num));
            _db.SaveChanges();
        }
    }
}
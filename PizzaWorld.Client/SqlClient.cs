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

        public void DeletePizza(long num)
        {
            _db.Remove(_db.Pizzas.Single(p => p.EntityId == num));
            _db.SaveChanges();
        }
    }
}
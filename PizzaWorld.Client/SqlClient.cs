using System.Collections.Generic;
using System.Linq;
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
        public void CreateStore()
        {
            Save(new Store());
        }
    }
}
using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Store : AEntity
    {
        public List<Order> Orders { get; set; }

        public string Name {get; set;}

        public int Revenue {get; set;}

        public Store(){
            Orders = new List<Order>();
            Revenue = 0;
        }
        //  method to create orders
        public void CreateOrder()
        {
            Orders.Add(new Order());
        }
        // method to delete orders 

        // pass order as argument to find order
        
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
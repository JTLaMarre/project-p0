using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Store : AEntity
    {
        public List<Order> Orders { get; set; }
        //  method to create orders
        public void CreateOrder()
        {
            Orders.Add(new Order());
        }
        // method to delete orders 

        // pass order as argument to find order
        bool DeleteOrder(Order order)
        {
            try
            {
                // delete the order
                Orders.Remove(order);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
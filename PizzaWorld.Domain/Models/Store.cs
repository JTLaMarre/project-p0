using System.Collections.Generic;

namespace PizzaWorld.Domain.Models
{
    public class Store
    {
        public List<Order> Orders { get; set; }
        //  method to create orders
        void CreateOrder()
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
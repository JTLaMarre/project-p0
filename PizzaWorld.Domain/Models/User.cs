using System.Collections.Generic;
using System.Linq;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class User : AEntity 
    {
        public List<Order> Orders { get; set; }
        public Store SelectedStore { get; set; }
        

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var p in Orders.Last().Pizzas)
            {
                sb.AppendLine(p.Name);
            }
            {

            }
            return $"You have selected this store {SelectedStore.Name} and ordered \n{sb.ToString()}\n{Orders.Last().Pizzas.Count}:Pizzas \nTotal: ${Orders.Last().Total}";
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaWorld.Domain.Models
{
    public class User
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
            return $"You have selected this store {SelectedStore} and ordered {sb.ToString()} Total: ${Orders.Last().Total}";
        }
    }
}

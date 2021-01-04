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

        public string Name {get;set;}
        

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var p in Orders.Last().Pizzas)
            {
                sb.AppendLine(p.Name);
            }
            {
// \n{sb.ToString()}
            }
            return $"--- From Store:{SelectedStore.Name} ----- \nPizzas:{Orders.Last().Pizzas.Count}\nTotal: ${Orders.Last().Total}";
        }
    }
}

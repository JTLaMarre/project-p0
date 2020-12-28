using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
  public class MeatPizza : APizzaModel
  {
    protected override void AddName()
        {
          Name = "Meat Pizza";
        }
    protected override void AddCrust()
    {
      Crust C = new Crust();
      Crust = C.type;

    }

    protected override void AddSize()
    {
      Size S = new Size();
      Size = S.size;
    }

    protected override void AddToppings()
    {
      Toppings T = new Toppings();
      T.toppings = "Meats, Sauce";
      Toppings = T.toppings;
    
    }
  }
}
using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
  public class PepperoniPizza : APizzaModel
  {
   protected override void AddName()
        {
          Name = "Pepperoni Pizza";
        }
    protected override void AddCrust()
    {
      Crust = "Regular";
    }

    protected override void AddSize()
    {
      Size = "Medium";
    }

    protected override void AddToppings()
    {
      Toppings = "Pepp";
    }
  }
}
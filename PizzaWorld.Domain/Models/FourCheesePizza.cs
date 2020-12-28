using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class FourCheesePizza : APizzaModel
    {
        protected override void AddName()
        {
          Name = "Four Cheese Pizza";
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
            Toppings tops = new Toppings();

            tops.toppings = "Four Cheeses, Sauce";
            Toppings = tops.toppings;
      
        }
    }
}
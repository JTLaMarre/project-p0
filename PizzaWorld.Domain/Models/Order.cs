using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Factories;

namespace PizzaWorld.Domain.Models
{
    public class Order
    {
        private GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();

        public List<APizzaModel> Pizzas { get; set; }

        private const string _path = @"./pizzaorder.xml";



        public Order()
        {
            Pizzas = new List<APizzaModel>();
        }

        public void MakeMeatPizza()
        {
            Pizzas.Add(_pizzaFactory.Make<MeatPizza>());
        }
        public void DisplayPizzaOptions()
        {
            System.Console.WriteLine("Pepperoni Pizza");
            System.Console.WriteLine("Four Cheese Pizza");
            System.Console.WriteLine("Veggie Pizza");
            System.Console.WriteLine("Meat Pizza");
            System.Console.WriteLine("Choose a Pizza by number or enter 0 to finish adding pizzas to order");
        }
        public int SelectPizza()
        {
            int.TryParse(System.Console.ReadLine(), out int input);
            return input;
        }
        public void AddPizza()
        {
            var choice = (SelectPizza());

            if (choice == 1)
            {

                Pizzas.Add(_pizzaFactory.Make<PepperoniPizza>());
                System.Console.WriteLine("Pepperoni Pizza Added to Order");
                AddPizza();

            }
            else if (choice == 2)
            {

                Pizzas.Add(_pizzaFactory.Make<FourCheesePizza>());
                System.Console.WriteLine("Four Cheese Pizza Added to Order");
                AddPizza();

            }
            else if (choice == 3)
            {

                Pizzas.Add(_pizzaFactory.Make<VeggiePizza>());
                System.Console.WriteLine("Veggie Pizza Added to Order");
                AddPizza();

            }
            else if (choice == 4)
            {

                Pizzas.Add(_pizzaFactory.Make<MeatPizza>());
                System.Console.WriteLine("Meat Pizza Added to Order");
                AddPizza();

            }
            else if (choice == 0)
            {
              System.Console.WriteLine("Finished Ordering..");
              
            }
            else
            {
                System.Console.WriteLine("Choose a valid option");
                AddPizza();
            }
        }





    }
}
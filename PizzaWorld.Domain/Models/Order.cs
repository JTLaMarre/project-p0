using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Factories;

namespace PizzaWorld.Domain.Models
{
    public class Order : AEntity
    {
        private GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();

        public List<APizzaModel> Pizzas { get; set; }


        public int Total;

        public Order()
        {
            Pizzas = new List<APizzaModel>();
        }


        public void DisplayPizzaOptions()
        {
            System.Console.WriteLine("$10 Pepperoni Pizza");
            System.Console.WriteLine("$10 Four Cheese Pizza");
            System.Console.WriteLine("$10 Veggie Pizza");
            System.Console.WriteLine("$10 Meat Pizza");
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
                // check to see if amount of pizza is less than 50
                if (Pizzas.Count < 25)
                {

                    Pizzas.Add(_pizzaFactory.Make<PepperoniPizza>());
                    System.Console.WriteLine("Pepperoni Pizza Added to Order");
                    AddPizza();
                    Total = Total + 10;
                }
                else
                {
                    Console.WriteLine("Max Order amount reached");

                }
            }
            else if (choice == 2)
            {

                if (Pizzas.Count < 25)
                {

                    Pizzas.Add(_pizzaFactory.Make<FourCheesePizza>());
                    System.Console.WriteLine("Four Cheese Pizza Added to Order");
                    AddPizza();
                    Total = Total + 10;
                }
                else
                {
                    Console.WriteLine("Max Order amount reached");

                }

            }
            else if (choice == 3)
            {
                if (Pizzas.Count < 25)
                {

                    Pizzas.Add(_pizzaFactory.Make<VeggiePizza>());
                    System.Console.WriteLine("Veggie Pizza Added to Order");
                    AddPizza();
                    Total = Total + 10;
                }
                else
                {
                    Console.WriteLine("Max Order amount reached");

                }
            }
            else if (choice == 4)
            {
                if (Pizzas.Count < 25 )
                {

                    Pizzas.Add(_pizzaFactory.Make<MeatPizza>());
                    System.Console.WriteLine("Meat Pizza Added to Order");
                    AddPizza();
                    Total = Total + 10;
                }
                else
                {
                    Console.WriteLine("Max Order amount reached");

                }
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
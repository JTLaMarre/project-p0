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
        public long UserEntityId { get; set; }

// TODO Remove then restruct db this number Id isn't used;
        public long OrderId {get; set;}



        public int Total;

        public Order()
        {
            Pizzas = new List<APizzaModel>();
            
        }


        public void DisplayPizzaOptions()
        {
            System.Console.WriteLine("1--$10 Med Pepperoni Pizza");
            System.Console.WriteLine("2--$10 Med Four Cheese Pizza");
            System.Console.WriteLine("3--$10 Med Veggie Pizza");
            System.Console.WriteLine("4--$10 Med Meat Pizza");
            System.Console.WriteLine("5--$10 Large Meat Pizza");
            System.Console.WriteLine("6--$10 Large Pepperoni Pizza");
            System.Console.WriteLine("7--$10 Large Four Cheese Pizza");
            System.Console.WriteLine("8--$10 Large Veggie Pizza");
        
            

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
                    APizzaModel p =_pizzaFactory.Make<PepperoniPizza>();
                    p.OrderId=EntityId;
                    Pizzas.Add(p);
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
                   APizzaModel p = _pizzaFactory.Make<FourCheesePizza>();
                    p.OrderId = EntityId;
                    Pizzas.Add(p);
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
                    APizzaModel p = _pizzaFactory.Make<VeggiePizza>();
                    p.OrderId=EntityId;
                    Pizzas.Add(p);
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
                    APizzaModel p = _pizzaFactory.Make<MeatPizza>();
                    p.OrderId = EntityId;
                    Pizzas.Add(p);
                    System.Console.WriteLine("Meat Pizza Added to Order");
                    AddPizza();
                    Total = Total + 10;
                }
                else
                {
                    Console.WriteLine("Max Order amount reached");

                }
            }
            else if (choice == 5)
            {
                if (Pizzas.Count < 25 )
                {
                    APizzaModel p = _pizzaFactory.Make<MeatPizza>();
                    p.OrderId = EntityId;
                    p.Size = "Large";
                    Pizzas.Add(p);
                    System.Console.WriteLine("Meat Pizza Added to Order");
                    AddPizza();
                    Total = Total + 10;
                }
                else
                {
                    Console.WriteLine("Max Order amount reached");

                }
            }
            else if (choice == 6)
            {
                if (Pizzas.Count < 25 )
                {
                    APizzaModel p = _pizzaFactory.Make<PepperoniPizza>();
                    p.OrderId = EntityId;
                    Pizzas.Add(p);
                    System.Console.WriteLine("Pepperoni Pizza Added to Order");
                    AddPizza();
                    Total = Total + 10;
                }
                else
                {
                    Console.WriteLine("Max Order amount reached");

                }
            }
            else if (choice == 7)
            {
                if (Pizzas.Count < 25 )
                {
                    APizzaModel p = _pizzaFactory.Make<FourCheesePizza>();
                    p.OrderId = EntityId;
                    Pizzas.Add(p);
                    System.Console.WriteLine("Four Cheese Added to Order");
                    AddPizza();
                    Total = Total + 10;
                }
                else
                {
                    Console.WriteLine("Max Order amount reached");

                }
            }
            else if (choice == 8)
            {
                if (Pizzas.Count < 25 )
                {
                    APizzaModel p = _pizzaFactory.Make<VeggiePizza>();
                    p.OrderId = EntityId;
                    Pizzas.Add(p);
                    System.Console.WriteLine("Veggie Added to Order");
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
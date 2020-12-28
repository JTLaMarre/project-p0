using System;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Crust : AEntity
    {
        public string type { get; set; }

        public Crust()
        {
            type = "regular";
        }

        
    }
}
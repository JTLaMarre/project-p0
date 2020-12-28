using System;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Size : AEntity
    {
        public string size { get; set; }

        public Size()
        {
            size = "med";
        }

        
    }
}
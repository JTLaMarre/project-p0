using System;

namespace PizzaWorld.Domain.Abstracts
{

    public abstract class AEntity
    {
        public long EntityId { get; }

        protected AEntity()
        {
            // EntityId = DateTime.Now.Ticks;
        }
    }
}
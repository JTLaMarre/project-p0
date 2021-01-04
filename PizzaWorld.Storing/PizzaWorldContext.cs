// EF Core is ORM
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Storing
{


    public class PizzaWorldContext : DbContext
    {
        // Properties are the model for the DB
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        public virtual  DbSet<User> Users { get; set; }

        public virtual DbSet<APizzaModel> Pizzas { get; set; }

        // connect our ORM "EF Core" to DB
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=tcp:jacobpizzaworlddb.database.windows.net,1433;Initial Catalog=PizzaWorldDB;Persist Security Info=False;User ID=bob;Password=");
        }
        

        // Tells SQL When building these tables do this 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Store>().HasKey(s => s.EntityId);
            builder.Entity<User>().HasKey(u => u.EntityId);
            builder.Entity<Order>().HasKey(o => o.EntityId);
            builder.Entity<APizzaModel>().HasKey(p => p.EntityId);
            builder.Entity<Crust>().HasKey(c => c.EntityId);
            builder.Entity<Size>().HasKey(z => z.EntityId);
            builder.Entity<Toppings>().HasKey(t => t.EntityId);

            SeedData(builder);
        }

        protected void SeedData(ModelBuilder builder)
        {
            builder.Entity<Store>().HasData( new List<Store>
                {
                    new Store() {EntityId= 5, Name = "LaMarrinos"},
                    new Store() {EntityId= 6, Name = "Meetzeronis"}
                }
            );
            builder.Entity<User>().HasData( new List<User>
                {
                    new User() {EntityId= 1, Name = "UserA"},
                    new User() {EntityId= 2, Name = "UserB"}
                }
            );
        }
        
    }
}
// EF Core is ORM
using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Storing
{

    
    public class PizzaWorldContext : DbContext
    {
        // Properties are the model for the DB
        public DbSet<Store> Stores { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<APizzaModel> Pizzas { get; set; }

        // connect our ORM "EF Core" to DB
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=tcp:jacobpizzaworlddb.database.windows.net,1433;Initial Catalog=PizzaWorldDB;User ID=bob;Password=");
        }

        // Tells SQL When building these tables do this 
        protected override void OnModelCreating(ModelBuilder builder){
        builder.Entity<Store>().HasKey(s => s.EntityId);
        builder.Entity<User>().HasKey(u => u.EntityId);
        builder.Entity<Order>().HasKey(o => o.EntityId);
        builder.Entity<APizzaModel>().HasKey(p => p.EntityId);
        } 
    }
}
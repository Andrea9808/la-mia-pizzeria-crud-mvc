using Microsoft.EntityFrameworkCore;

namespace La_mia_pizzeria.Models
{
    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-pizzas;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}

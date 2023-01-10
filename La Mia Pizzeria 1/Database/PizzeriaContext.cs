using Microsoft.EntityFrameworkCore;
using NetCore_01.Models;

namespace NetCore_01.Database
{
    public class PizzeriaContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=MiaPizzeria01;" +
            "Integrated Security=True;TrustServerCertificate=True");
        }
    }
}

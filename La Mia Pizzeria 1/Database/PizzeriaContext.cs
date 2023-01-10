using Microsoft.EntityFrameworkCore;

namespace La_Mia_Pizzeria_1.Database
{
    public class PizzeriaContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        OptionsBuilder.UseSqlServer("Data Source=localhost;Database=PizzeraDb;" + "Integrated Security=True;TrustServerCertificate=True");
    }
}

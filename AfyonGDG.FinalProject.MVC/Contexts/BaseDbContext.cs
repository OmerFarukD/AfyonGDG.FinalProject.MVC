using AfyonGDG.FinalProject.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AfyonGDG.FinalProject.MVC.Contexts;

public class BaseDbContext : DbContext
{


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server = (localdb)\\MSSQLLocalDB; Database=Afyon_GDG_DB; Trusted_Connection=true");
    }

    public DbSet<Product> Products { get; set; }

    public DbSet<Category> Categories { get; set; }
}

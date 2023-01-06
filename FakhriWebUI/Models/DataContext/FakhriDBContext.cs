using FakhriWebUI.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace FakhriWebUI.Models.DataContext
{
    public class FakhriDBContext:DbContext
    {
        public FakhriDBContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}

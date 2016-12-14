using Marktkaart.Models;
using Microsoft.EntityFrameworkCore;

namespace Marktkaart.Data
{
    public class MarktkaartDbContext : DbContext
    {
        public DbSet<Markt> Markten { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Markten.db");
        }
    }
}
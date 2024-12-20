using Microsoft.EntityFrameworkCore;
using RunGroop.Models;

namespace RunGroop.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet <Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}


using Microsoft.EntityFrameworkCore;
using KernelTravelGuides.Models;

namespace KernelTravelGuides.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        public DbSet<TravelCategory> TravelCategories { get; set; }
        public DbSet<Resorts> Resorts { get; set; }
        public DbSet<Messages> Messages { get; set; }

        public DbSet<Restaurants> Restaurants { get; set; }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<TouriestSpots> TouriestSpots { get; set; }

        public DbSet<Packages> Packages { get; set; }
    }
}

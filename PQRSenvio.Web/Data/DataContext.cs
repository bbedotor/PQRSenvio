using Microsoft.EntityFrameworkCore;
using PQRSenvio.Web.Data.Entities;

namespace PQRSenvio.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Case> Cases { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Theme> Themes { get; set; }

    }
}

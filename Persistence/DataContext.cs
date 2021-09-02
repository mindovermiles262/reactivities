using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        // Constructor
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // Create an "Activites" table in the Database
        public DbSet<Activity> Activities { get; set; }
    }
}
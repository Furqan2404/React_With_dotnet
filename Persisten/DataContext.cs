using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persisten
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        } 
        public DbSet<Activity> Activities { get; set; } =null!;

        public DataContext(DbSet<Activity> activities)
        {
            Activities = activities;
        }
    }
}
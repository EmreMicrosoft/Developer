using Microsoft.EntityFrameworkCore;

namespace Developer.MsSql.Fundamentals.Samples
{
    // nuget packages: 
    // Microsoft.EntityFrameworkCore
    // Microsoft.EntityFrameworkCore.SqlServer

    public class BasicDataContext : DbContext
    {
        public BasicDataContext(DbContextOptions<BasicDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DatabaseName;Persist Security Info=True;User ID=sa;Password=1234");
            }
        }
    }

    // Entities:
    public class Users
    {
    }

    public class Notifications
    {
    }

    public class Categories
    {
    }
}
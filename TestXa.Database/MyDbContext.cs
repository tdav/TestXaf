using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TestXaf.Models;

namespace TestXa.Database
{
    public partial class MyDbContext : DbContext
    {
        public DbSet<spClass> spClasses { get; set; }
        public DbSet<tbProduct> tbProducts { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Filename=TestDatabase.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });

            base.OnConfiguring(options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
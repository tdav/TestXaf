using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TestXaf.Database
{
    public class MyUsersDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<MyDbContext>();
            options.UseSqlite("Host=127.0.0.1;Database=license_db;Username=postgres;Password=postgres;Pooling=true;")
                   .EnableDetailedErrors();

            return new MyDbContext(options.Options);
        }
    }
}

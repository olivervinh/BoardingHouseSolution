using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace BoardingHouse.Infrastructure.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var optionsBuider = new DbContextOptionsBuilder<AppDbContext>();
            var connectionString = configuration.GetConnectionString("db");
            optionsBuider.UseSqlServer(connectionString);
            return new AppDbContext(optionsBuider.Options);
        }
    }
}
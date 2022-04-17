using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardingHouse.Domain.HouseDomain.Models;
using Microsoft.EntityFrameworkCore;

namespace BoardingHouse.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<House> Houses { get; set; }
    }
}

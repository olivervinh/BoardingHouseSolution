using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardingHouse.Domain.HouseDomain.Models;
using BoardingHouse.Domain.UserDomain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BoardingHouse.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<HouseType> HouseTypes { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Convenience> Conveniences { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}

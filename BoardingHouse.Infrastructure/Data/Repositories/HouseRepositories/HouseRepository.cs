using BoardingHouse.Domain.HouseDomain.IRepositories;
using BoardingHouse.Domain.HouseDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardingHouse.Infrastructure.Data.Repositories.HouseRepositories
{
    public class HouseRepository : Repository<House>, IHouseRepository
    {
        public HouseRepository(AppDbContext context) : base(context)
        {
        }
    }
}
using BoardingHouse.Domain.HouseDomain.IRepositories;
using BoardingHouse.Domain.HouseDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardingHouse.Infrastructure.Data.Repositories.HouseRepositories
{
    public class ConvenienceRepository : Repository<Convenience>, IConvenienceRepository
    {
        public ConvenienceRepository(AppDbContext context) : base(context)
        {
        }
    }
}
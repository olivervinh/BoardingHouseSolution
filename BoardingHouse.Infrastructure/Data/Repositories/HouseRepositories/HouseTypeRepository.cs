using BoardingHouse.Domain.HouseDomain.IRepositories;
using BoardingHouse.Domain.HouseDomain.Models;

namespace BoardingHouse.Infrastructure.Data.Repositories.HouseRepositories
{
    public class HouseTypeRepository : Repository<HouseType>, IHouseTypeRepository
    {
        public HouseTypeRepository(AppDbContext context) : base(context)
        {
        }
    }
}
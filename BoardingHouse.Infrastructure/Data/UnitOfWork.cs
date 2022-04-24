using BoardingHouse.Domain.Base.Interfaces;
using BoardingHouse.Domain.HouseDomain.IRepositories;
using BoardingHouse.Infrastructure.Data.Repositories.HouseRepositories;
using System.Threading.Tasks;

namespace BoardingHouse.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IHouseRepository Houses { get; private set; }
        public IHouseTypeRepository HouseTypes { get; private set; }
        public IConvenienceRepository Conveniences { get; private set; }
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Houses = new HouseRepository(context);
            HouseTypes = new HouseTypeRepository(context);
            Conveniences = new ConvenienceRepository(context);
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
          
        }
    }
}

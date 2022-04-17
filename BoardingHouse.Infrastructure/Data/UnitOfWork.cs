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
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Houses = new HouseRepository(context);
        }

        public async Task CommitAsync()
        {
           
        }

        public void Dispose()
        {
          
        }
    }
}

using BoardingHouse.Domain.HouseDomain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardingHouse.Domain.Base.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IHouseRepository Houses { get; }
        IHouseTypeRepository HouseTypes { get; }
        IConvenienceRepository Conveniences { get; }
        Task CommitAsync();
    }
}
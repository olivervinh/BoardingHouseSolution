using BoardingHouse.Domain.Base.Interfaces;
using BoardingHouse.Domain.HouseDomain.Models;
using BoardingHouse.Infrastructure.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardingHouse.Application.Services.HouseServices
{
    public class ShopService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShopService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<House>> GetPaginationHousesAsync(int? pageNumber)
        {
            var conditions = _unitOfWork.Houses.GetQueryable();
            var paginations = await PagedPaginationHelper<House>.CreateAsync(conditions, pageIndex: pageNumber??1, pageSize:6);
            return paginations;
        }
    }
}

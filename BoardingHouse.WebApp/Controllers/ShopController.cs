using BoardingHouse.Application.Services.HouseServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardingHouse.WebApp.Controllers
{
    public class ShopController : Controller
    {
        private HouseService _houseService;
        public ShopController(HouseService houseService)
        {
            _houseService = houseService;
        }
        public async Task<IActionResult> Index(int? pageNumber)
        {
            return  View(await _houseService.GetPaginationHousesAsync(pageNumber));
        }
    }
}

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
        private ShopService _shopService;
        public ShopController(ShopService shopService)
        {
            _shopService = shopService;
        }
        public async Task<IActionResult> Index(int? pageNumber)
        {
            ViewBag.list_HouseTypes = await _shopService.GetHouseTypesAsync();
            ViewBag.list_Conveniences = await _shopService.GetConveniencesAsync();
            return  View(await _shopService.GetPaginationHousesAsync(pageNumber));
        }
    }
}

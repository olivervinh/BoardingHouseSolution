using BoardingHouse.Domain.HouseDomain.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BoardingHouse.Infrastructure.Data
{
    public class DataSeeding
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //if (!context.Houses.Any()) 
                //{
                //    for (int i = 0; i < 1000000; i++)
                //    {
                //        Random rnd = new Random();
                //        var house = new House();
                //        house.Acreage = rnd.Next(15, 25);
                //        house.UnitAcreage = "m";
                //        house.ElectricityPrice = 3500;
                //        house.UnitElectricityPrice = "Kwh";
                //        house.HousePrice = 2500000;
                //        house.UnitHousePrice = "month";
                //        house.HouseStatus = "Available";
                //        house.IsParkingVehicleInRoom = true;
                //        house.NumberMezzanine = 1;
                //        house.PublicationDate = DateTime.Now;
                //        house.UnitWaterPrice = "user";
                //        house.WaterPrice =100000;
                //        house.Capacity = rnd.Next(2,5);
                //        house.Description = @"Comfortable hostel near the city center area, cheap price";
                //        context.Add(house);
                //        context.SaveChanges();
                //    }
                //}
            }
        }
    }
}

using BoardingHouse.Domain.HouseDomain.Models;
using BoardingHouse.Domain.UserDomain.Models;
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
                if (!context.HouseTypes.Any())
                {
                    var houseType = new HouseType();
                    houseType.Name = "House";
                    context.HouseTypes.Add(houseType);
                    context.SaveChanges();
                    houseType = new HouseType();
                    houseType.Name = "Single Family";
                    context.HouseTypes.Add(houseType);
                    context.SaveChanges();
                    houseType = new HouseType();
                    houseType.Name = "Apartment";
                    context.HouseTypes.Add(houseType);
                    context.SaveChanges();
                    houseType = new HouseType();
                    houseType.Name = "Office Villa";
                    context.HouseTypes.Add(houseType);
                    context.SaveChanges();
                    houseType = new HouseType();
                    houseType.Name = "Luxary Home";
                    context.HouseTypes.Add(houseType);
                    context.SaveChanges();
                    houseType = new HouseType();
                    houseType.Name = "Studio";
                    context.HouseTypes.Add(houseType);
                    context.SaveChanges();
                }
                if (!context.AppUsers.Any())
                {
                    AppUser appUser = new AppUser();
                    appUser.FirstName = "Trần Quý";
                    appUser.LastName = "Vinh";
                    appUser.PhoneNumber = "0868420530";
                    appUser.Email = "olivervinh@gmail.com";
                    context.Add(appUser);
                    context.SaveChanges();
                    appUser = new AppUser();
                    appUser.FirstName = "Trần Chí";
                    appUser.LastName = "Nhân";
                    appUser.PhoneNumber = "0965423695";
                    appUser.Email = "nhan@gmail.com";
                    context.Add(appUser);
                    context.SaveChanges();
                    appUser = new AppUser();
                    appUser.FirstName = "Đoàn Ngọc";
                    appUser.LastName = "Hải";
                    appUser.PhoneNumber = "0875426395";
                    appUser.Email = "hai@gmail.com";
                    context.Add(appUser);
                    context.SaveChanges();
                    appUser = new AppUser();
                    appUser.FirstName = "Nguyễn Văn";
                    appUser.LastName = "Bình";
                    appUser.PhoneNumber = "0987563595";
                    appUser.Email = "binh@gmail.com";
                    context.Add(appUser);
                    context.SaveChanges();
                    appUser = new AppUser();
                    appUser.FirstName = "Vũ Hải";
                    appUser.LastName = "Yến";
                    appUser.PhoneNumber = "0897456630";
                    appUser.Email = "yen@gmail.com";
                    context.Add(appUser);
                    context.SaveChanges();

                }
                if (!context.Houses.Any())
                {
                    for (int i = 0; i <=50; i++)
                    {
                        Random rnd = new Random();
                        var house = new House();
                        house.Acreage = rnd.Next(15, 25);
                        house.UnitAcreage = "m";
                        house.ElectricityPrice = 3500;
                        house.UnitElectricityPrice = "Kwh";
                        house.HousePrice = int.Parse(rnd.Next(15, 25) + "00000");
                        house.UnitHousePrice = "month";
                        house.HouseStatus = "Available";
                        house.IsParkingVehicleInRoom = true;
                        house.NumberMezzanine = 1;
                        house.PublicationDate = DateTime.Now;
                        house.UnitWaterPrice = "user";
                        house.WaterPrice = 100000;
                        house.Capacity = rnd.Next(2, 5);
                        house.Description = @"Comfortable hostel near the city center area, cheap price";
                        context.Add(house);
                        context.SaveChanges();
                    }
                }
                if (!context.Conveniences.Any())
                {
                    var convenience = new Convenience();
                    convenience.Name = "Dishwater";
                    context.Conveniences.Add(convenience);
                    context.SaveChanges();
                    convenience = new Convenience();
                    convenience.Name = "Floor Coverings";
                    context.Conveniences.Add(convenience);
                    context.SaveChanges();
                    convenience = new Convenience();
                    convenience.Name = "Internet";
                    context.Conveniences.Add(convenience);
                    context.SaveChanges();
                    convenience = new Convenience();
                    convenience.Name = "Build Wardorbes";
                    context.Conveniences.Add(convenience);
                    context.SaveChanges();
                    convenience = new Convenience();
                    convenience.Name = "Supermarket";
                    context.Conveniences.Add(convenience);
                    context.SaveChanges();
                    convenience = new Convenience();
                    convenience.Name = "Kids Zone";
                    context.Conveniences.Add(convenience);
                    context.SaveChanges();
                }
            }
        }
    }
}

using BoardingHouse.Application.Services.HouseServices;
using BoardingHouse.Domain.Base.Interfaces;
using BoardingHouse.Domain.HouseDomain.IRepositories;
using BoardingHouse.Infrastructure.Data;
using BoardingHouse.Infrastructure.Data.Repositories;
using BoardingHouse.Infrastructure.Data.Repositories.HouseRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BoardingHouse.Application.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            // Configure DbContext with Scoped lifetime
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("db"));
                options.UseLazyLoadingProxies();
            }
            );

            services.AddScoped<Func<AppDbContext>>((provider) => () => provider.GetService<AppDbContext>());
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IRepository<>), typeof(Repository<>))
                .AddScoped<IHouseRepository, HouseRepository>();
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddScoped<ShopService>();
        }
    }
}

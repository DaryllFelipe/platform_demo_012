using DataAccess.Private.Repository.Interfaces;
using DataAccess.Private.Repository.Repositories;
using DataAccess.Private.Services;
using DataAccess.Public.Interaces.Services;
using Microsoft.Extensions.DependencyInjection;
namespace DataAccess.Public
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerOrderRepository, CustomerOrderRepository>();
            services.AddScoped<ICustomerService, CustomerService>();
            return services;
        }
    }
}

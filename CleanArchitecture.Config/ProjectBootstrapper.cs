using CleanArchitecture.Application.Orders;
using CleanArchitecture.Application.Products;
using CleanArchitecture.Contracts;
using CleanArchitecture.Domain.Orders.IOrderRepository;
using CleanArchitecture.Domain.Products.IProductRepository;
using CleanArchitecture.Infrastructure;
using CleanArchitecture.Infrastructure.Presistance.Memory;
using CleanArchitecture.Infrastructure.Presistance.Memory.Orders;
using CleanArchitecture.Infrastructure.Presistance.Memory.Products;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Config
{
    public class ProjectBootstrapper
    {
        public static void Initialize(IServiceCollection service)
        {
            service.AddTransient<IOrderService, OrderService>();
            service.AddTransient<IProductService, ProductService>();
            service.AddTransient<IOrderRepository, OrderRepository>();
            service.AddTransient<IProductRepository, ProdutcRepository>();


            service.AddScoped<ISmsService,SmsService>();
            service.AddSingleton<Context>();

        }
    }
}

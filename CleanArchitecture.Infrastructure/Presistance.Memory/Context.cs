using CleanArchitecture.Domain.Orders;
using CleanArchitecture.Domain.Products;

namespace CleanArchitecture.Infrastructure.Presistance.Memory
{
   public class Context
    {
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }

    }
}

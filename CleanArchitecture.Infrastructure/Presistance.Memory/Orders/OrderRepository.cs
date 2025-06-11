using CleanArchitecture.Domain.Orders;
using CleanArchitecture.Domain.Orders.IOrderRepository;

namespace CleanArchitecture.Infrastructure.Presistance.Memory.Orders
{
    public class OrderRepository : IOrderRepository
    {
        private Context _context;

        public void Add(Order order)
        {
            _context.Orders.Add(order);
        }
        public Order GetById(long Id)
        {
           return _context.Orders.FirstOrDefault(f => f.Id == Id);
        }
        public List<Order> GetList()
        {
            return _context.Orders;
        }
        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Order order)
        {
           var oldOrder = GetById(order.Id);
            if (oldOrder == null)
                throw new ArgumentException("Order not found");
            _context.Orders.Remove(oldOrder);
            Add(order);
        }
    }
}

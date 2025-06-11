namespace CleanArchitecture.Domain.Orders.IOrderRepository
{
    public interface IOrderRepository
    {
        List<Order> GetList();
        Order GetById(long Id);
        void Add(Order order);
        void Update(Order order);
        void SaveChanges();

    }
}

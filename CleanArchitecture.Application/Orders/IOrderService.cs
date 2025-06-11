using CleanArchitecture.Application.Orders.DTOs;

namespace CleanArchitecture.Application.Orders
{
    public interface IOrderService
    {
        void AddOrder(AddOrderDto command);
        void FinallyOrder(FinallyOrderDto command);
        OrderDto GetOrderById(long id);
        List<OrderDto> GetOrders();

    }
}

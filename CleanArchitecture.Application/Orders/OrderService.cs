using CleanArchitecture.Domain.Orders;
using CleanArchitecture.Application.Orders.DTOs;
using CleanArchitecture.Domain.Orders.IOrderRepository;
using CleanArchitecture.Contracts;


namespace CleanArchitecture.Application.Orders
{
   
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;
        private ISmsService _smsService;


        public OrderService(IOrderRepository repository,ISmsService smsService)
        {
            _repository = repository;
            _smsService = smsService;
        }

        public void AddOrder(AddOrderDto command)
        {
            var order = new Order(command.ProductId, command.Count, command.Price);
            _repository.Add(order);
            _repository.SaveChanges();
        }

        public void FinallyOrder(FinallyOrderDto command)
        {
            var order = _repository.GetById(command.OrderId);
            order.Finally();
            _repository.Update(order);
            _repository.SaveChanges();
            _smsService.SendSms(new SmsBody()
            {
                Message = $"Your order with ID {command.OrderId} has been finalized.",
                PhoneNumber = "+93777387376"

            });
        }

        public OrderDto GetOrderById(long id)
        {
           var result = _repository.GetById(id);
            if (result == null)
                throw new Exception("Order not found");
            return new OrderDto
            {
                Id = result.Id,
                ProductId = result.ProductId,
                Count = result.Count,
                Price = result.Price
            };
        }

        public List<OrderDto> GetOrders()
        {
            return _repository.GetList().Select(order => new OrderDto()
            {
                Id = order.Id,
                ProductId = order.ProductId,
                Count = order.Count,
                Price = order.Price
            }).ToList();
        }
    }
}

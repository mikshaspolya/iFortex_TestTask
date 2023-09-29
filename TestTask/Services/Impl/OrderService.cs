using TestTask.Models;
using TestTask.Repositories.Interfaces;
using TestTask.Services.Interfaces;

namespace TestTask.Services.Impl
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Task<Order> GetOrder()
        {
            return Task.FromResult(_orderRepository.GetOrder());
        }

        public Task<List<Order>> GetOrders()
        {
            return Task.FromResult(_orderRepository.GetOrders());
        }
    }
}

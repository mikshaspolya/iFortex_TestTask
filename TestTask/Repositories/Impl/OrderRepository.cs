using TestTask.Data;
using TestTask.Models;
using TestTask.Repositories.Interfaces;

namespace TestTask.Repositories.Impl
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Order GetOrder()
        {
            return _context.Orders
                .OrderByDescending(order => order.Price * order.Quantity)
                .FirstOrDefault();
        }

        public List<Order> GetOrders()
        {
            return _context.Orders
                .Where(order => order.Quantity > 10)
                .ToList();
        }
    }
}

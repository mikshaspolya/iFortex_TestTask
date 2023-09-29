using TestTask.Models;

namespace TestTask.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        public Order GetOrder();

        public List<Order> GetOrders();
    }
}

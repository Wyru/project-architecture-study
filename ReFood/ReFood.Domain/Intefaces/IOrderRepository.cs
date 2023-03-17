using ReFood.Domain.Entities;

namespace ReFood.Domain.Intefaces
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> OrdersAsync();
        Task<IEnumerable<Order>> OrdersAsync(Protagonist protagonist);
        Task<Order> GetByIdAsync(int? id);
        Task<Order> CreateAsync(Order order);
        Task<Order> UpdateAsync(Order order);
        Task<Order> RemoveAsync(Order order);
    }
}

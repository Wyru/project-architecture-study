using ReFood.Domain.Entities;

namespace ReFood.Domain.Intefaces
{
    public interface IStoreRepository
    {
        Task<IEnumerable<Store>> GetProtagonistsAsync();
        Task<Store> GetByIdAsync(int? id);
        Task<Store> CreateAsync(Store store);
        Task<Store> UpdateAsync(Store store);
        Task<Store> RemoveAsync(Store store);
    }
}

using ReFood.Domain.Entities;

namespace ReFood.Domain.Intefaces
{
    public interface IProtagonistRepository
    {
        Task<IEnumerable<Protagonist>> GetProtagonistsAsync();
        Task<Protagonist> GetByIdAsync(int? id);
        Task<Protagonist> CreateAsync(Protagonist protagonist);
        Task<Protagonist> UpdateAsync(Protagonist protagonist);
        Task<Protagonist> RemoveAsync(Protagonist protagonist);
    }
}

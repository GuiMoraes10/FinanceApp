using FinanceApp.DTOs;
using FinanceApp.Entities;

namespace FinanceApp.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public Task<User> CreateAsync(User user);
        public Task<User?> GetIdAsync(string id);
        public Task<User> UpdateAsync(User user);
        public Task<bool> DeleteAsync(string id);
    }
}

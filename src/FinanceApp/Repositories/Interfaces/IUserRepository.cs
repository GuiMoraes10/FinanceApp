using FinanceApp.DTOs;
using FinanceApp.Entities;

namespace FinanceApp.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public Task<User> CreateUserAsync(User user);
        public Task<User?> GetUserByIdAsync(string id);
        public Task<User> UpdateUserAsync(User user);
        public Task<bool> DeleteUserAsync(string id);
    }
}

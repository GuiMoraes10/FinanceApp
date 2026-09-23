using FinanceApp.Models;

namespace FinanceApp.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public Task<User> CreateAsync(User user);
        public Task<User?> GetByIdAsync(string id);
    }
}

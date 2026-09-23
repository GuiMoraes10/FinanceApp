using FinanceApp.Models;

namespace FinanceApp.Services.Interfaces
{
    public interface IUserService
    {
        public Task<User> CreateNewUserAsync(string name);
    }
}

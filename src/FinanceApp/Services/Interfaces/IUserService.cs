using FinanceApp.DTOs;
using FinanceApp.Entities;

namespace FinanceApp.Services.Interfaces
{
    public interface IUserService
    {
        public Task<User> CreateNewUser(UserRegisterDto dto);
        public Task<User?> GetUserById(string id);
        public Task<bool> DeleteUserAsync(string id);
        public Task<User?> UpdateUser(string id, UpdateUserDto dto);
        public Task<bool> SetUserBalance(string id, decimal value);
        public Task<bool> SetUserPassword(string id, string value);
    }
}

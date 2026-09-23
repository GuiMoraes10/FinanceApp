using FinanceApp.DTOs;
using FinanceApp.Entities;
using FinanceApp.Repositories.Interfaces;
using FinanceApp.Services.Interfaces;
using Newtonsoft.Json.Linq;

namespace FinanceApp.Services
{
    public class UserService(IUserRepository repository) : IUserService
    {
        IUserRepository _repository = repository;

        public async Task<User> CreateNewUser(UserRegisterDto dto)
        {
            User user = new()
            {
                Name = dto.Name,
                UserName = dto.UserName,
                Password = dto.Password,
            };

            return await _repository.CreateUserAsync(user);
        }


        public async Task<User?> GetUserById(string id)
        {
            return await _repository.GetUserByIdAsync(id);
        }

        public async Task<bool> DeleteUserAsync(string id)
        {
            return await _repository.DeleteUserAsync(id);
        }

        public async Task<bool> SetUserBalance(string id, decimal value)
        {
            User? user = await _repository.GetUserByIdAsync(id);

            if (user is null)
                return false;

            user.Balance = value;

            user = await _repository.UpdateUserAsync(user);

            return user.Balance == value;
        }

        public async Task<User?> UpdateUser(string id, UpdateUserDto dto)
        {
            User? user = await _repository.GetUserByIdAsync(id);

            if (user is null)
                return null;

            user.Name = dto.Name;
            user.UserName = dto.UserName;

            user = await _repository.UpdateUserAsync(user);

            return user;
        }

        public async Task<bool> SetUserPassword(string id, string value)
        {
            User? user = await _repository.GetUserByIdAsync(id);

            if (user is null)
                return false;

            user.Password = value;

            user = await _repository.UpdateUserAsync(user);

            return user.Password == value;
        }

        // Metodos que alteram o balance com increment e decrement, devem vir de transaction

    }
}

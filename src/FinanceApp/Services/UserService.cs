using FinanceApp.Models;
using FinanceApp.Repositories.Interfaces;
using FinanceApp.Services.Interfaces;

namespace FinanceApp.Services
{
    public class UserService (IUserRepository reppository) : IUserService
    {
        IUserRepository _reppository = reppository;

        public async Task<User> CreateNewUserAsync(string name)
        {
            User user = new()
            {
                Name = name,
            };

            return await _reppository.CreateAsync(user);
        }

    }
}

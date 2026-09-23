using FinanceApp.Configuration;
using FinanceApp.Repositories.Interfaces;
using Microsoft.Azure.Cosmos;
using System.Text.Json;

namespace FinanceApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Container _container;

        public UserRepository(CosmosDbConfiguration cosmos)
        {
            _container = cosmos.Users;
        }

        public async Task<Entities.User> CreateUserAsync(Entities.User user)
        {
            var response = await _container.CreateItemAsync(
                user,
                new PartitionKey(user.Id));

            return response.Resource;
        }

        public async Task<Entities.User?> GetUserByIdAsync(string id)
        {
            try
            {
                var response = await _container.ReadItemAsync<Entities.User>(
                    id,
                    new PartitionKey(id));

                return response.Resource;
            }
            catch (CosmosException ex)
                when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public async Task<Entities.User> UpdateUserAsync(Entities.User user)
        {
            var response = await _container.ReplaceItemAsync(
                user,
                user.Id,
                new PartitionKey(user.Id));

            return response.Resource;
        }

        public async Task<bool> DeleteUserAsync(string id)
        {
            try
            {
                await _container.DeleteItemAsync<Entities.User>(
                    id,
                    new PartitionKey(id));

                return true;
            }
            catch (CosmosException ex)
                when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return false;
            }
        }
    }
}

using FinanceApp.Configuration;
using FinanceApp.Entities;
using FinanceApp.Repositories.Interfaces;
using Microsoft.Azure.Cosmos;

namespace FinanceApp.Repositories
{
    public class TransactionRepository(CosmosDbConfiguration cosmos) : ITransactionRepository
    {
        private readonly Container _container = cosmos.Transactions;

        public async Task<Transaction> CreateAsync(Transaction transaction)
        {
            var response = await _container.CreateItemAsync(transaction, new PartitionKey(transaction.UserId));

            return response.Resource;
        }

        public async Task<Transaction?> GetByIdAsync(string id, string userId)
        {
            try
            {
                var response = await _container.ReadItemAsync<Transaction>(id, new PartitionKey(userId));

                return response.Resource;
            }
            catch (CosmosException ex)
                when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public async Task<Transaction> UpdateAsync(Transaction transaction)
        {
            var response = await _container.ReplaceItemAsync(transaction, transaction.Id, new PartitionKey(transaction.UserId));

            return response.Resource;
        }

        public async Task<bool> DeleteAsync(string id, string userId)
        {
            try
            {
                await _container.DeleteItemAsync<Transaction>(id, new PartitionKey(userId));

                return true;
            }
            catch (CosmosException ex)
                when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Transaction>> GetByUserIdAsync(string userId)
        {
            var query = new QueryDefinition("SELECT * FROM c WHERE c.userId = @userId").WithParameter("@userId", userId);

            var results = new List<Transaction>();

            using FeedIterator<Transaction> iterator = _container.GetItemQueryIterator<Transaction>(
                query,
                requestOptions: new QueryRequestOptions
                {
                    PartitionKey = new PartitionKey(userId)
                });

            while (iterator.HasMoreResults)
            {
                var response = await iterator.ReadNextAsync();
                results.AddRange(response);
            }

            return results;
        }
    }
}

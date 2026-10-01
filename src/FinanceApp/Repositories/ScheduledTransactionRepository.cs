using FinanceApp.Configuration;
using FinanceApp.Entities;
using FinanceApp.Repositories.Interfaces;
using Microsoft.Azure.Cosmos;

namespace FinanceApp.Repositories
{
    public class ScheduledTransactionRepository : IScheduledTransactionRepository
    {

        public ScheduledTransactionRepository(CosmosDbConfiguration cosmos)
        {
            _container = cosmos.ScheduledTransactions;
        }

        private readonly Container _container;

        public async Task<ScheduledTransaction> CreateAsync(ScheduledTransaction transaction)
        {
            var response = await _container.CreateItemAsync(transaction, new PartitionKey(transaction.UserId));

            return response.Resource;
        }

        public async Task<ScheduledTransaction?> GetByIdAsync(string id, string userId)
        {
            try
            {
                var response = await _container.ReadItemAsync<ScheduledTransaction>(id, new PartitionKey(userId));

                return response.Resource;
            }
            catch (CosmosException ex)
                when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public async Task<ScheduledTransaction> UpdateAsync(ScheduledTransaction transaction)
        {
            var response = await _container.ReplaceItemAsync(transaction, transaction.Id, new PartitionKey(transaction.UserId));

            return response.Resource;
        }

        public async Task<bool> DeleteAsync(string id, string userId)
        {
            try
            {
                await _container.DeleteItemAsync<ScheduledTransaction>(id, new PartitionKey(userId));

                return true;
            }
            catch (CosmosException ex)
                when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return false;
            }
        }

        public async Task<IEnumerable<ScheduledTransaction>> GetByUserIdAsync(string userId)
        {
            var query = new QueryDefinition("SELECT * FROM c WHERE c.userId = @userId").WithParameter("@userId", userId);

            var results = new List<ScheduledTransaction>();

            using FeedIterator<ScheduledTransaction> iterator =_container.GetItemQueryIterator<ScheduledTransaction>(
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

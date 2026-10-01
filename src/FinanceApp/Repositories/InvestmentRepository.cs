using FinanceApp.Configuration;
using FinanceApp.Entities;
using FinanceApp.Repositories.Interfaces;
using Microsoft.Azure.Cosmos;


namespace FinanceApp.Repositories
{
    public class InvestmentRepository(CosmosDbConfiguration cosmos) : IInvestmentRepository
    {
        private readonly Container _container = cosmos.Investments;

        public async Task<Investment> CreateAsync(Investment investment)
        {
            var response = await _container.CreateItemAsync(investment, new PartitionKey(investment.UserId));

            return response.Resource;
        }

        public async Task<Investment?> GetByIdAsync(string id, string userId)
        {
            try
            {
                var response = await _container.ReadItemAsync<Investment>(id, new PartitionKey(userId));

                return response.Resource;
            }
            catch (CosmosException ex)
                when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public async Task<Investment> UpdateAsync(Investment investment)
        {
            var response = await _container.ReplaceItemAsync(investment, investment.Id, new PartitionKey(investment.UserId));

            return response.Resource;
        }

        public async Task<bool> DeleteAsync(string id, string userId)
        {
            try
            {
                await _container.DeleteItemAsync<Investment>(id, new PartitionKey(userId));

                return true;
            }
            catch (CosmosException ex)
                when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Investment>> GetByUserIdAsync(string userId)
        {
            var query = new QueryDefinition("SELECT * FROM c WHERE c.userId = @userId").WithParameter("@userId", userId);

            var results = new List<Investment>();

            using FeedIterator<Investment> iterator = _container.GetItemQueryIterator<Investment>(
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

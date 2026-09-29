using Microsoft.Azure.Cosmos;

namespace FinanceApp.Configuration
{
    public class CosmosDbInitializer(CosmosClient cosmosClient)
    {
        private readonly CosmosClient _cosmosClient = cosmosClient;

        public async Task InitializeAsync()
        {
            DatabaseResponse databaseResponse =
            await _cosmosClient.CreateDatabaseIfNotExistsAsync("FinanceApp");

            Database database = databaseResponse.Database;

            await database.CreateContainerIfNotExistsAsync(
                new ContainerProperties("Users", "/id"));

            await database.CreateContainerIfNotExistsAsync(
                new ContainerProperties("Transactions", "/userId"));

            await database.CreateContainerIfNotExistsAsync(
                new ContainerProperties("ScheduledTransactions", "/userId"));

            await database.CreateContainerIfNotExistsAsync(
                new ContainerProperties("Investments", "/userId"));
        }
    }
}

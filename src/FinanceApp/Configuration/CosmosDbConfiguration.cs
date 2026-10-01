using Microsoft.Azure.Cosmos;

namespace FinanceApp.Configuration
{
    public class CosmosDbConfiguration
    {
        public Database Database { get; }

        public Container Users { get; }
        public Container Transactions { get; }
        public Container ScheduledTransactions { get; }
        public Container Investments { get; }

        public CosmosDbConfiguration(CosmosClient cosmosClient)
        {
            Database = cosmosClient.GetDatabase("FinanceApp");
            Users = Database.GetContainer("Users");
            Transactions = Database.GetContainer("Transactions");
            ScheduledTransactions = Database.GetContainer("ScheduledTransactions");
            Investments = Database.GetContainer("Investments");
        }
    }
}

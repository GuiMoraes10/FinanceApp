using Microsoft.Azure.Cosmos;

namespace FinanceApp.Configuration
{
    public class CosmosDbConfiguration
    {
        public Database Database { get; }

        public Container Users { get; }

        public CosmosDbConfiguration(CosmosClient cosmosClient)
        {
            Database = cosmosClient.GetDatabase("FinanceApp");
            Users = Database.GetContainer("Users");
        }
    }
}

using System.Text.Json.Serialization;

namespace FinanceApp.Models
{
    public class User
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; } = string.Empty;
    }
}

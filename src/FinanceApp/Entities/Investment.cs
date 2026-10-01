namespace FinanceApp.Entities
{
    public class Investment
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string UserId { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public decimal Balance { get; set; }

        public decimal EstimatedPercent { get; set; }
    }
}

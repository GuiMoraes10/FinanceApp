namespace FinanceApp.Entities
{
    public class ScheduledTransaction
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string UserId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Value { get; set; } = 0;
        public int Day { get; set; }
        public bool Recurring { get; set; }
        public int? RemainingOccurrences { get; set; } = 1;
        public bool Active { get; set; } = true;
        public TransactionType Type {  get; set; }
    }
}

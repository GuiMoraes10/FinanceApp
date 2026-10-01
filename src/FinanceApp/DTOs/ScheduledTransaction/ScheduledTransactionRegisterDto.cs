using FinanceApp.Entities;

namespace FinanceApp.DTOs.ScheduledTransaction
{
    public class ScheduledTransactionRegisterDto
    {
        public required string UserId { get; set; }
        public required string Name { get; set; }
        public decimal Value { get; set; }
        public int Day { get; set; }
        public bool Recurring { get; set; }
        public int? RemainingOcurrences { get; set; }
        public TransactionType Type { get; set; }
    }
}

using FinanceApp.Entities;

namespace FinanceApp.DTOs.ScheduledTransaction
{
    public class ScheduledTransactionUpdateDto
    {
        public required string Name { get; set; }
        public decimal Value { get; set; }
        public int Day { get; set; }
        public bool Recurring { get; set; }
        public int? RemainingOccurrences { get; set; }
        public TransactionType Type { get; set; }
    }
}

using FinanceApp.Entities;

namespace FinanceApp.DTOs.Transaction
{
    public class TransactionRegisterDto
    {
        public required string UserId { get; set; }
        public required string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }
        public TransactionCategory Category { get; set; }
    }
}
